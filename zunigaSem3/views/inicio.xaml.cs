using System.Text.RegularExpressions;

private void SoloLetras_TextChanged(object sender, TextChangedEventArgs e)
{
    var entry = sender as Entry;

    if (entry == null)
        return;

    string texto = Regex.Replace(entry.Text ?? "", @"[^a-zA-ZáéíóúÁÉÍÓÚñÑ ]", "");

    if (entry.Text != texto)
        entry.Text = texto;
}