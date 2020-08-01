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
        public static bool ValidaTexto(string texto)
        {
            Regex rg = new Regex("[A-Z]");
            return rg.IsMatch(texto);
        }
        public static bool ValidaSite(string texto)
        {
            Regex rg = new Regex("(http|http(s)?://)?([/w-]+/.)+[/w-]+[.com|.in|.org]");
            return rg.IsMatch(texto);
        }

        public static bool ValidaNumero(string texto)
        {
            Regex rg = new Regex("[0-9]");
            return rg.IsMatch(texto);
        }

        public static Boolean ValidaEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
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

        /// <summary>
        /// Verifica campos que aceitam numeros e letras
        /// </summary>
        /// <param name="senderEvent"></param>
        /// <param name="e"></param>
        public static void TxtMask_ValidaNumeroLetras_KeyPress(object senderEvent, KeyPressEventArgs e)
        {
            var sender = senderEvent as TextBox;
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Space) )
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// verificar todos os campos que só aceitam numeros
        /// </summary>
        /// <param name="senderEvent"></param>
        /// <param name="e"></param>
        public static void TxtMask_Numero_KeyPress(object senderEvent, KeyPressEventArgs e)
        {
            var sender = senderEvent as TextBox;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
               e.Handled = true;
            }
        }

        /// <summary>
        /// verificar campos que só aceitam letras
        /// </summary>
        /// <param name="senderEvent"></param>
        /// <param name="e"></param>
        public static void TxtMask_Sexo_KeyPress(object senderEvent, KeyPressEventArgs e)
        {
            var sender = senderEvent as TextBox;
            if (Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if ((e.KeyChar == 'M') | (e.KeyChar == 'F'))
                {
                    
                }
            }
        }

        public static void TxtMask_Letras_KeyPress(object senderEvent, KeyPressEventArgs e)
        {
            var sender = senderEvent as TextBox;
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
            }
        }

        public static bool IsPis(string pis)
        {
            int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            if (pis.Trim().Length != 11)
                return false;
            pis = pis.Trim();
            pis = pis.Replace("-", "").Replace(".", "").PadLeft(11, '0');

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(pis[i].ToString()) * multiplicador[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            return pis.EndsWith(resto.ToString());
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
