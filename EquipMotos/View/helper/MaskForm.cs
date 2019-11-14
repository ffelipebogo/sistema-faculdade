using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.View.helper
{
    static class MaskForm
    {
        public static bool ValidaTexto(String texto)
        {
            Regex rg = new Regex("[A-Z]");

            return rg.IsMatch(texto);
        }

        public static void TxtMask_Porcentagem_KeyUp(object senderEvent, KeyEventArgs e)
        {
            var sender = senderEvent as TextBox;
            var valor = Convert.ToDecimal("0"+sender.Text);
            if (valor > 100)
            {
                MessageBox.Show("Informe uma porcentagem igual ou menor que 100!", "Porcentagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sender.Text = "";
                sender.Focus();
            }
        }

        public static void TxtMask_Porcentagem_KeyPress(object senderEvent, KeyPressEventArgs e)
        {
            var sender = senderEvent as TextBox;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (sender.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        public static void TxtMask_Porcentagem_Leave(object senderEvent, EventArgs e)
        {
            var sender = senderEvent as TextBox;
            try
            {
                sender.Select(sender.Text.Length, 0);
            }
            catch (Exception)
            {

            }
        }

        public static void TxtMask_Valida_KeyPress(object senderEvent, KeyPressEventArgs e)
        {
            var sender = senderEvent as TextBox;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = (sender.Text.Contains("."));
                }
                else
                    e.Handled = true;
            }
        }

        public static void TxtMask_Moeda_KeyPress(object senderEvent, KeyPressEventArgs e)
        {
            var sender = senderEvent as TextBox;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (sender.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        public static void TxtMask_Moeda_KeyUp(object senderEvent, KeyEventArgs e)
        {
            var sender = senderEvent as TextBox;
            var vlr = sender.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (vlr.Length == 0)
            {
                sender.Text = "0,00" + vlr;
            }
            if (vlr.Length == 1)
            {
                sender.Text = "0,0" + vlr;
            }
            if (vlr.Length == 2)
            {
                sender.Text = "0," + vlr;
            }
            else if (vlr.Length >= 3)
            {
                if (sender.Text.StartsWith("0,"))
                {
                    sender.Text = vlr.Insert(vlr.Length - 2, ",").Replace("0,", "");
                }
                else if (sender.Text.Contains("00,"))
                {
                    sender.Text = vlr.Insert(vlr.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    sender.Text = vlr.Insert(vlr.Length - 2, ",");
                }
            }
            vlr = sender.Text;
            sender.Text = string.Format("{0:C}", Convert.ToDouble("0" + Double.Parse(vlr, NumberStyles.Any)));
            sender.Select(sender.Text.Length, 0);
        }

        public static void TxtMask_Moeda_Leave(object senderEvent, EventArgs e)
        {
            var sender = senderEvent as TextBox;
            try
            {
                var vlr = sender.Text.Replace("R$", "");
                sender.Text = string.Format("{0:C}", Convert.ToDouble("0" + vlr));
            }
            catch (Exception)
            {

            }
        }
    }
}
