using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Userinterface : Form
    {
        public Userinterface()
        {
            InitializeComponent();
        }

        string _word;

        private int _wide = 50;
    
        private readonly Font _font = new Font("Segoe UI", 12, GraphicsUnit.Point);
       
        private readonly Padding _pad = new Padding(5);

        Hang man = new Hang();
        private void NewClick(object sender, EventArgs e)
        {
            Textpromt textprompt = new Textpromt();
            string word = _word;
            if (textprompt.ShowDialog(this) == DialogResult.OK)
            {
                _word = textprompt.Word().Trim().ToLower();
            }
            else
            {
                return;
            }
            textprompt.Dispose();
            if (_word == "")
            {
                return;
            }
            else if (_word != word)
            {
                
                uxWord.Controls.Clear();
                NewLetters();
                man.ReadWord(_word);
                for (int i = 0; i < _word.Length; i++)
                {
                    Label slot = new Label();
                    slot.Text = _word[i].ToString();
                    slot.BackColor = Color.Beige;
                    slot.Margin = new Padding(0);
                    slot.TextAlign = ContentAlignment.MiddleCenter;
                    slot.Font = new Font(FontFamily.GenericMonospace.ToString(), 16);
                    slot.BorderStyle = BorderStyle.FixedSingle;
                    slot.Width = uxWord.Width / _word.Length;
                    slot.Height = uxWord.Height;
                    uxWord.Controls.Add(slot);
                }


            }


        }

        private void NewLetters()
        {
            uxLetters.Controls.Clear();
            char let = 'a';
            while(let<= 'z')
            {
                Button set = new Button
                {
                    Text = let.ToString(),
                    Width = _wide,
                    Height = _font.Height + _pad.Top,
                    Margin = _pad,
                };
                set.Click += new EventHandler(ButtonClick);//creates the event
                uxLetters.Controls.Add(set);
                let++;
            }

        }


        public void ButtonClick(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            if (pressed != null)
            {
                
                char letter = pressed.Text[0];
                
                
                for( int i = 0; i< _word.Length; i++)
                {
                    if (man.contains.TryGetValue(i, out char l)){
                        for ( int j =0; j< _word.Length; j++)
                        {
                            

                        }
                    }
                }



            }
        }

    }
}
