﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public static class RABotProgram
{
    public static string TempFolder;

    private const string TempFolderName = "RAbot";

    public static void SetTempFolder()
    {
        string temp = Path.GetTempPath();
        TempFolder = Path.Combine(temp, TempFolderName);
        DeleteTempFolder();
        Directory.CreateDirectory(TempFolder);
    }

    public static void DeleteTempFolder()
    {
        if (Directory.Exists(TempFolder))
        {
            try
            {
                Directory.Delete(TempFolder, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            
        }
    }

    public static string UnloadImage(Bitmap bitmap, string name)
    {
        string path = Path.Combine(TempFolder, name + ".png");
        if (!File.Exists(path))
        {
            bitmap.Save(path, ImageFormat.Png);
        }
        return path;
    }

    public static void SetLittleStops()
    {
        if (Clipboard.ContainsText())
        {
            FindInstruments(Clipboard.GetText());
        }
    }

    private static Dictionary<TradeInstrument.Issuer, double> FindInstruments(string text)
    {
        Dictionary<TradeInstrument.Issuer, double> dictionary = new Dictionary<TradeInstrument.Issuer, double>();
        string[] lineSplit = text.Split('\n', '\r');
        bool isFutures = true;
        foreach (string line in lineSplit)
        {
            if (!string.IsNullOrEmpty(line))
            {
                string lineWoCommas = line.Trim(':', ';');
                if (lineWoCommas == SLSettings.FuturesName)
                {
                    isFutures = true;
                    continue;
                }
                if (lineWoCommas == SLSettings.StocksName)
                {
                    isFutures = false;
                    continue;
                }
                string[] issuerAndStop = lineWoCommas.Split(' ');
                TradeInstrument.Issuer issuer = TradeInstrument.GetIssuer(issuerAndStop[0], isFutures);
                dictionary.Add(issuer, StringFunctions.Parse(issuerAndStop[1]));
            }
            
        }
        return dictionary;
    }
}

