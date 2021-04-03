using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OSMaker
{
    public class RichScript
    {
        [DllImport("user32.dll")]
        private static extern bool LockWindowUpdate(IntPtr hWndLock);

        private RichTextBox _MyRichScript;

        public RichTextBox MyRichScript
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MyRichScript;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MyRichScript != null)
                {

                    /// <summary>
    /// Handle KeyPress: pour remettre la couleur de l'écriture à l'origine.
    /// </summary>
    /// <param name="sender">Object</param>
    /// <param name="e">KeyPressEventArgs</param>
    /// <remarks></remarks>
                    _MyRichScript.KeyPress -= RichScript_KeyPress;

                    /// <summary>
    /// Handle TextChanged: pour appliquer la couleur à chaque changements.
    /// </summary>
    /// <param name="sender">Object</param>
    /// <param name="e">EventArgs</param>
    /// <remarks></remarks>
                    _MyRichScript.TextChanged -= RichScript_TextChanged;
                }

                _MyRichScript = value;
                if (_MyRichScript != null)
                {
                    _MyRichScript.KeyPress += RichScript_KeyPress;
                    _MyRichScript.TextChanged += RichScript_TextChanged;
                }
            }
        }

        private struct _PaintWords
        {
            public Color WordsColor;
            public string[] WordsToFind;
        }

        private List<_PaintWords> MyRichWords;
        private _PaintWords MyRichComments;

        /// <summary>
    /// Initialise une instance qui permet d'utiliser d'enrichir un RichTextBox en RichScript.
    /// </summary>
    /// <param name="LinkedRichText">Objet RichTextBox à prendre le contrôle</param>
    /// <param name="BackColor">Couleur d'arrière plan</param>
    /// <param name="ForeColor">Couleur du texte</param>
    /// <remarks></remarks>
        public RichScript(ref RichTextBox LinkedRichText, Color BackColor, Color ForeColor)
        {
            MyRichWords = new List<_PaintWords>();
            MyRichComments = default;
            MyRichScript = LinkedRichText;
            MyRichScript.BackColor = BackColor;
            MyRichScript.ForeColor = ForeColor;
            MyRichScript.TabStop = false;
        }

        /// <summary>
    /// Ferme l'instance du RichScript.
    /// </summary>
    /// <remarks></remarks>
        public void Disposed()
        {
            MyRichComments = default;
            MyRichWords.Clear();
            MyRichScript.Clear();
        }

        /// <summary>
    /// Force le RichScript à repeindre les mots.
    /// </summary>
    /// <returns>Retourne le nombre d'élements contenus dans la liste des mots</returns>
    /// <remarks></remarks>
        public int RefreshWords()
        {
            RichScriptColors();
            if (MyRichWords is object)
            {
                return MyRichWords.Count;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
    /// Ajouter un ou plusieurs mots colorés au contrôle RichScript.
    /// </summary>
    /// <param name="WordsColor">Couleur qui sera utilisé pour peindre le mot</param>
    /// <param name="WordsToFind">Tableau des mots à peindre</param>
    /// <returns>Retourne le nombre d'élements contenus dans la liste des mots</returns>
    /// <remarks>Exemple: AddWords(Color.Green, "Pomme", "Herbe", "Arbre")</remarks>
        public int AddWords(Color WordsColor, params string[] WordsToFind)
        {
            var nEntry = new _PaintWords() { WordsColor = WordsColor, WordsToFind = WordsToFind };
            MyRichWords.Add(nEntry);
            return MyRichWords.Count;
        }

        /// <summary>
    /// Colore une ligne entière selon les premiers caractères.
    /// </summary>
    /// <param name="CommentsColor">Couleur qui sera utilisé pour peindre la ligne</param>
    /// <param name="CommentsToFind">Tableau des premiers caractères de la ligne à peindre</param>
    /// <remarks>Exemple: SetComments(Color.Green, "''' ", ";")</remarks>
        public void SetComments(Color CommentsColor, params string[] CommentsToFind)
        {
            var nEntry = new _PaintWords() { WordsColor = CommentsColor, WordsToFind = CommentsToFind };
            MyRichComments = nEntry;
        }

        /// <summary>
    /// Fonction qui regroupe les procédures à éffectuer sur les mots sans scintillement.
    /// </summary>
    /// <remarks>Pour tester le problème de scintillement, mettez en commentaire les lignes executant LockWindowUpdate</remarks>
        private void RichScriptColors()
        {
            LockWindowUpdate(MyRichScript.Handle);
            int i = MyRichScript.SelectionStart;

            // Liste de mots à colorer
            for (int j = 0, loopTo = MyRichWords.Count - 1; j <= loopTo; j++)
                PaintWords(MyRichWords[j].WordsColor, MyRichWords[j].WordsToFind);

            // Colore une ligne entière comme commentaire
            if (MyRichComments.WordsColor != default)
            {
                for (int k = 0, loopTo1 = MyRichScript.Lines.Count() - 1; k <= loopTo1; k++)
                {
                    if (MyRichScript.Lines[k].Length > 0)
                    {
                        for (int m = 0, loopTo2 = MyRichComments.WordsToFind.Count() - 1; m <= loopTo2; m++)
                        {
                            if (MyRichScript.Lines[k].Length >= MyRichComments.WordsToFind[m].Length)
                            {
                                if ((MyRichScript.Lines[k].Substring(0, MyRichComments.WordsToFind[m].Length) ?? "") == (MyRichComments.WordsToFind[m] ?? ""))
                                {
                                    MyRichScript.SelectionStart = MyRichScript.GetFirstCharIndexFromLine(k);
                                    MyRichScript.SelectionLength = MyRichScript.Lines[k].Length;
                                    MyRichScript.SelectionColor = MyRichComments.WordsColor;
                                }
                            }
                        }
                    }
                }
            }

            MyRichScript.SelectionLength = 0;
            MyRichScript.SelectionStart = i;
            LockWindowUpdate(IntPtr.Zero);
        }


        /// <summary>
    /// Fonction principale qui selectionne un mot et le paint.
    /// </summary>
    /// <param name="WordsColor">Couleur qui sera utilisé pour peindre le mot</param>
    /// <param name="WordsToFind">Tableau des mots à peindre</param>
    /// <remarks></remarks>
        private void PaintWords(Color WordsColor, params string[] WordsToFind)
        {
            foreach (string Word in WordsToFind)
            {
                int idx = MyRichScript.Find(Word, 0, RichTextBoxFinds.None);
                while (idx > -1)
                {
                    if ((MyRichScript.Text.Substring(idx, Word.Length) ?? "") == (Word ?? ""))
                    {
                        MyRichScript.SelectionStart = idx;
                        MyRichScript.SelectionLength = Word.Length;
                        MyRichScript.SelectionColor = WordsColor;
                    }
                    else if ((MyRichScript.Text.Substring(idx, Word.Length).ToUpper() ?? "") == (Word.ToUpper() ?? ""))
                    {
                        MyRichScript.SelectionStart = idx;
                        MyRichScript.SelectionLength = Word.Length;
                        MyRichScript.SelectionColor = WordsColor;
                        // FORCE TYPE
                        MyRichScript.SelectedText = Word;
                    }

                    if (idx + Word.Length >= MyRichScript.TextLength)
                    {
                        idx = -1;
                    }
                    else
                    {
                        idx = MyRichScript.Find(Word, idx + Word.Length, RichTextBoxFinds.None);
                    }
                }
            }
        }

        private void RichScript_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyRichScript.SelectionColor = MyRichScript.ForeColor;
        }

        private void RichScript_TextChanged(object sender, EventArgs e)
        {
            if (MyRichWords.Count == 0)
                return;
            if (MyRichScript.SelectionLength > 0)
                return;
            RichScriptColors();
        }
    }
}