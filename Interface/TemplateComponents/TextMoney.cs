﻿namespace Interface.TemplateComponents
{
    public class TextMoney : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(225, 19);
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);

        }
        string valor;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);
            if (Text.Length > 4 && this.SelectionStart > (uint)Text.Length - 3)
            {
                SelectionStart = TextLength - 4;
            }
            else if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                KeyUp += new KeyEventHandler(key);
                void key(Object o, KeyEventArgs e)
                {
                    valor = Text;
                    if (valor == "")
                        valor = "R$ 0,00";

                    valor = valor.Replace("R$", "").Replace(",", "");

                    if (valor.Length == 1)
                        valor = "00,0" + valor;
                    else if (valor.Length == 2)
                        valor = "00," + valor;
                    else
                        valor = valor.Insert(valor.Length - 2, ",");

                    Text = string.Format("{0:c}", Convert.ToDouble(valor));
                    Select(Text.Length, 0);
                }


            }

            else
                e.Handled = true;
        }

        public double returnValue()
        {
            double value = double.Parse(Text.Replace("R$", ""));
            return value;
        }
    }
}
