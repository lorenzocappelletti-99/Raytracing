using System;
public class HdrImage
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Color[] Pixels { get; set; }

    // Costruttore che inizializza l'immagine con una larghezza e un'altezza
    public HdrImage(int width = 0, int height = 0)
    {
        Width = width;
        Height = height;
        Pixels = new Color[Width * Height];

        // Inizializza tutti i pixel a nero
        for (int i = 0; i < Pixels.Length; i++)
        {
            Pixels[i] = new Color();
        }
    }
    
    public Color GetPixel(int x, int y)
    {
        // Verifica che le coordinate siano valide
        if (x < 0 || x >= Width || y < 0 || y >= Height)
        {
            throw new ArgumentOutOfRangeException("Le coordinate del pixel sono fuori dai limiti dell'immagine.");
        }

        // Restituisce il colore del pixel
        return Pixels[y * Width + x];
    }
    
    // Imposta il colore di un pixel specificato dalle coordinate
    public void SetPixel(int x, int y, Color newColor)
    {
        // Verifica che le coordinate siano valide
        if (x < 0 || x >= Width || y < 0 || y >= Height)
        {
            throw new ArgumentOutOfRangeException("Le coordinate del pixel sono fuori dai limiti dell'immagine.");
        }

        // Imposta il nuovo colore per il pixel
        Pixels[y * Width + x] = newColor;
    }
}

}