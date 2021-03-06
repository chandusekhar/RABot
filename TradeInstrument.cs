﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

/// <summary>
/// Класс для работы с данными об эмитенте
/// </summary>
public class TradeInstrument
{
    /// <summary>
    /// Эмитент
    /// </summary>
    public enum Issuer
    {
        /// <summary>
        /// Евродоллар
        /// </summary>
        EURUSD,
        /// <summary>
        /// Отсутствующий эмитент
        /// </summary>
        None,
        /// <summary>
        /// ФСК
        /// </summary>
        Fsk,
        /// <summary>
        /// Газпром
        /// </summary>
        Gazprom,
        /// <summary>
        /// ГМКНорНикель
        /// </summary>
        GmkNorNikel,
        /// <summary>
        /// Лукойл
        /// </summary>
        Lukoil,
        /// <summary>
        /// ММК
        /// </summary>
        Mmk,
        /// <summary>
        /// Мвидео
        /// </summary>
        Mvideo,
        /// <summary>
        /// Мосбиржа
        /// </summary>
        Moex,
        /// <summary>
        /// МТС
        /// </summary>
        Mts,
        /// <summary>
        /// Роснефть
        /// </summary>
        Rosneft,
        /// <summary>
        /// Ростелеком
        /// </summary>
        Rostelekom,
        /// <summary>
        /// Сбербанк ао
        /// </summary>
        SberbankAo,
        /// <summary>
        /// Сбербанк ап
        /// </summary>
        SberbankAp,
        /// <summary>
        /// Северсталь
        /// </summary>
        Severstal,
        /// <summary>
        /// СургутНефтеГаз ао
        /// </summary>
        SurgutNfgAo,
        /// <summary>
        /// СургутНефетГаз ап
        /// </summary>
        SurgutNfgAp,
        /// <summary>
        /// Юнипро
        /// </summary>
        Unipro,
        /// <summary>
        /// Уралкалий
        /// </summary>
        Uralkaliy,
        /// <summary>
        /// ВТБ
        /// </summary>
        Vtb,
        /// <summary>
        /// Фьючерс на нефть WTI
        /// </summary>
        FWTI,
        /// <summary>
        /// Фьючерс на доллар-рубль
        /// </summary>
        FUSDRUR,
        /// <summary>
        /// Фьючерс на золото
        /// </summary>
        FGold,
        /// <summary>
        /// Фьючерс на Евро
        /// </summary>
        FEU,
        /// <summary>
        /// Фьючерс на акции Газпрома
        /// </summary>
        FGazprom,
        /// <summary>
        /// Фьючерс на акции ГмкНорникеля
        /// </summary>
        FGmkNorNikel,
        /// <summary>
        /// Фьючерс на обыкновенные акции Сбербанка
        /// </summary>
        FSberbankAo,
        /// <summary>
        /// Фьючерс на привилигерованные акции Сбербанка
        /// </summary>
        FSberbankAp,
        /// <summary>
        /// Фьючерс на акции ВТБ
        /// </summary>
        FVtb,
        /// <summary>
        /// Фьючерс на акции Магнита
        /// </summary>
        FMagnit
    }

    /// <summary>
    /// Метод возвращает код эмитента
    /// </summary>
    /// <param name="issuer">Эмитент</param>
    /// <returns></returns>
    public static string GetIssuerCode(Issuer issuer)
    {
        switch (issuer)
        {
            case Issuer.EURUSD:
                return "";
            case Issuer.Fsk:
                return "FEES";
            case Issuer.Gazprom:
                return "GAZP";
            case Issuer.GmkNorNikel:
                return "GMKN";
            case Issuer.Lukoil:
                return "LKOH";
            case Issuer.Mvideo:
                return "MVID";
            case Issuer.Mmk:
                return "MAGN";
            case Issuer.Moex:
                return "MOEX";
            case Issuer.Mts:
                return "MTSS";
            case Issuer.Rosneft:
                return "ROSN";
            case Issuer.Rostelekom:
                return "RTKM";
            case Issuer.SberbankAo:
                return "SBER";
            case Issuer.SberbankAp:
                return "SBERP";
            case Issuer.Severstal:
                return "CHMF";
            case Issuer.SurgutNfgAo:
                return "SNGS";
            case Issuer.SurgutNfgAp:
                return "SNGSP";
            case Issuer.Unipro:
                return "UPRO";
            case Issuer.Uralkaliy:
                return "URKA";
            case Issuer.Vtb:
                return "VTBR";
            case Issuer.FWTI:
                return "";
            case Issuer.FUSDRUR:
                return "";
            case Issuer.FGold:
                return "";
            case Issuer.FEU:
                return "";
            case Issuer.FGazprom:
                return "";
            case Issuer.FGmkNorNikel:
                return "";
            case Issuer.FSberbankAo:
                return "";
            case Issuer.FSberbankAp:
                return "";
            case Issuer.FVtb:
                return "";
            case Issuer.FMagnit:
                return "";
        }
        return null;
    }
    /// <summary>
    /// Метод возвращает название эмитента
    /// </summary>
    /// <param name="issuer">Эмитент</param>
    /// <returns></returns>
    public static string GetIssuerName(Issuer issuer)
    {
        switch (issuer)
        {
            case Issuer.EURUSD:
                return "EURUSD";
            case Issuer.Fsk:
                return "ФСК";
            case Issuer.Gazprom:
                return "Газпром";
            case Issuer.GmkNorNikel:
                return "ГМКНорНикель";
            case Issuer.Lukoil:
                return "Лукойл";
            case Issuer.Mvideo:
                return "М.Видео";
            case Issuer.Mmk:
                return "ММК";
            case Issuer.Moex:
                return "Мосбиржа";
            case Issuer.Mts:
                return "МТС";
            case Issuer.Rosneft:
                return "Роснефть";
            case Issuer.Rostelekom:
                return "Ростелеком";
            case Issuer.SberbankAo:
                return "Сбербанк ао";
            case Issuer.SberbankAp:
                return "Сбербанк ап";
            case Issuer.Severstal:
                return "Северсталь";
            case Issuer.SurgutNfgAo:
                return "СургутНефтеГаз ао";
            case Issuer.SurgutNfgAp:
                return "СургутНефтеГаз ап";
            case Issuer.Unipro:
                return "Юнипро";
            case Issuer.Uralkaliy:
                return "Уралкалий";
            case Issuer.Vtb:
                return "ВТБ";
            case Issuer.FWTI:
                return "ФWTI";
            case Issuer.FUSDRUR:
                return "ФUSDRUR";
            case Issuer.FGold:
                return "ФGold";
            case Issuer.FEU:
                return "ФEuro";
            case Issuer.FGazprom:
                return "ФГазпром";
            case Issuer.FGmkNorNikel:
                return "ФГмкНорНикель";
            case Issuer.FSberbankAo:
                return "ФСбербанк ао";
            case Issuer.FSberbankAp:
                return "ФСбербанк ап";
            case Issuer.FVtb:
                return "ФВТБ";
            case Issuer.FMagnit:
                return "ФМагнит";

        }
        return null;
    }
    /// <summary>
    /// Метод возвращает эмитент по его коду
    /// </summary>
    /// <param name="issuerCode">Код эмитента</param>
    /// <returns></returns>
    public static Issuer GetIssuer(string issuerCode)
    {
        switch (issuerCode)
        {
            case "FEES":
                return Issuer.Fsk;
            case "GAZP":
                return Issuer.Gazprom;
            case "GMKN":
                return Issuer.GmkNorNikel;
            case "LKOH":
                return Issuer.Lukoil;
            case "MOEX":
                return Issuer.Moex;
            case "MTSS":
                return Issuer.Mts;
            case "ROSN":
                return Issuer.Rosneft;
            case "RTKM":
                return Issuer.Rostelekom;
            case "SBER":
                return Issuer.SberbankAo;
            case "SBERP":
                return Issuer.SberbankAp;
            case "CHMF":
                return Issuer.Severstal;
            case "SNGS":
                return Issuer.SurgutNfgAo;
            case "SNGSP":
                return Issuer.SurgutNfgAp;
            case "VTBR":
                return Issuer.Vtb;
        }
        return Issuer.None;
    }
    /// <summary>
    /// Метод возвращает эмитент по его названию
    /// </summary>
    /// <param name="issureName">Название эмитента</param>
    /// <param name="isFutures">Да, если это фьючерс</param>
    /// <returns></returns>
    public static Issuer GetIssuerRa(string issureName, bool isFutures)
    {
        if (isFutures)
        {
            switch (issureName)
            {
                case "WTI":
                    return Issuer.FWTI;
                case "USDRUR":
                    return Issuer.FUSDRUR;
                case "GD":
                    return Issuer.FGold;
                case "EU":
                    return Issuer.FEU;
                case "ГП":
                    return Issuer.FGazprom;
                case "ГМК":
                    return Issuer.FGmkNorNikel;
                case "Сбер":
                    return Issuer.FSberbankAo;
                case "Сберп":
                    return Issuer.FSberbankAp;
                case "ВТБ":
                    return Issuer.FVtb;
                case "Магнит":
                    return Issuer.FMagnit;
            }
        }
        switch (issureName)
        {
            case "Э.ОН":
                return Issuer.Unipro;
            case "Уралкалий":
                return Issuer.Uralkaliy;
            case "Мосбиржа":
                return Issuer.Moex;
            case "М.Видео":
                return Issuer.Mvideo;
            case "ММК":
                return Issuer.Mmk;
            case "EURUSD":
                return Issuer.EURUSD;
            case "ФWTI":
                return Issuer.FWTI;
            case "ФUSDRUR":
                return Issuer.FUSDRUR;
            case "ФGD":
                return Issuer.FGold;
            case "ФEU":
                return Issuer.FEU;
            case "ФГазпром":
                return Issuer.FGazprom;
            case "ФГмкНорНикель":
                return Issuer.FGmkNorNikel;
            case "ФСбербанк ао":
                return Issuer.FSberbankAo;
            case "ФСбербанк ап":
                return Issuer.FSberbankAp;
            case "ФВТБ":
                return Issuer.FVtb;
            case "ФМагнит":
                return Issuer.FMagnit;
        }
        
        return Issuer.None;
    }
    /// <summary>
    /// Метод возвращает эмитент по его названию
    /// </summary>
    /// <param name="issureName">Название эмитента</param>
    /// <returns></returns>
    public static Issuer GetIssuer2Name(string issureName)
    {
        switch (issureName)
        {
            case "Уралкалий":
                return Issuer.Uralkaliy;
            case "Мосбиржа":
                return Issuer.Moex;
            case "М.Видео":
                return Issuer.Mvideo;
            case "Юнипро":
                return Issuer.Unipro;
            case "ММК":
                return Issuer.Mmk;
            case "EURUSD":
                return Issuer.EURUSD;
            case "ФWTI":
                return Issuer.FWTI;
            case "ФUSDRUR":
                return Issuer.FUSDRUR;
            case "ФGold":
                return Issuer.FGold;
            case "ФEuro":
                return Issuer.FEU;
            case "ФГазпром":
                return Issuer.FGazprom;
            case "ФГмкНорНикель":
                return Issuer.FGmkNorNikel;
            case "ФСбербанк ао":
                return Issuer.FSberbankAo;
            case "ФСбербанк ап":
                return Issuer.FSberbankAp;
            case "ФВТБ":
                return Issuer.FVtb;
            case "ФМагнит":
                return Issuer.FMagnit;
        }

        return Issuer.None;
    }

    /// <summary>
    /// Код эмитента
    /// </summary>
    public string Code
    {
        get;
        private set;
    }
    /// <summary>
    /// Наименование эмитента
    /// </summary>
    public string Name
    {
        get;
        private set;
    }

    private readonly Issuer _issuer;

    private readonly string _quotesFileName;
    private Dictionary <DateTime, Quote> _quotes;
    private Dictionary<DateTime, Deal> _deals;
    private Dictionary<DateTime, Deal> _simpleDeals;

    private const string DateCol = "C";
    private const string OpenCol = "E";
    private const string CloseCol = "H";
    private const string HighCol = "F";
    private const string LowCol = "G";
    private const string VolumeCol = "I";

    private const string DirectionDealCol = "K";
    private const string OpenDealCol = "L";
    private const string ReverseDealCol = "M";

    private const string NewDirectionDealCol = "O";
    private const string NewOpenDealCol = "P";
    private const string NewReverseDealCol = "Q";
    private const string NewProfitLostCol = "R";

    private const string SimpleDirectionDealCol = "T";
    private const string SimpleOpenDealCol = "U";
    private const string SimpleReverseDealCol = "V";
    private const string SimpleProfitLostCol = "W";

    private const int FirstRow = 2;

    private const string DateFormat = "ddMMyy";

    public TradeInstrument(string quotesFileName)
    {
        string shortFileName = Path.GetFileNameWithoutExtension(quotesFileName);
        string[] split = shortFileName.Split('_');
        Code = split[0].Trim();
        _issuer = GetIssuer(Code);
        Name = GetIssuerName(_issuer);
        _quotesFileName = quotesFileName;
    }

    public void ReadAllQuotes()
    {
        DateTime fDateTime = new DateTime(1, 1, 1);
        DateTime tDateTime = DateTime.Today;
        ReadQuotes(fDateTime, tDateTime);
    }

    public void ReadQuotes(DateTime fromDate, DateTime toDate)
    {
        using (ExcelClass xls = new ExcelClass())
        {
            try
            {
                _quotes = new Dictionary <DateTime, Quote>();
                xls.OpenDocument(_quotesFileName, false);
                string sDate = xls.GetCellStringValue(DateCol, FirstRow);
                int i = FirstRow;
                while (!string.IsNullOrEmpty(sDate))
                {
                    DateTime date = StringFunctions.GetDate(sDate, DateFormat);
                    if (date > fromDate && date < toDate)
                    {
                        decimal open = StringFunctions.ParseDecimal(xls.GetCellStringValue(OpenCol, i));
                        decimal close = StringFunctions.ParseDecimal(xls.GetCellStringValue(CloseCol, i));
                        decimal high = StringFunctions.ParseDecimal(xls.GetCellStringValue(HighCol, i));
                        decimal low = StringFunctions.ParseDecimal(xls.GetCellStringValue(LowCol, i));
                        ulong volume = ulong.Parse(xls.GetCellStringValue(VolumeCol, i));
                        Quote quote = new Quote(date, open, close, high, low, volume, i);
                        _quotes.Add(date, quote);
                    }
                    i++;
                    sDate = xls.GetCellStringValue(DateCol, i);
                }
            }
            finally 
            {
                xls.CloseDocument(false);
            }
        }
    }

    public void ReadAllRomanDeals()
    {
        DateTime fDateTime = new DateTime(1, 1, 1);
        DateTime tDateTime = DateTime.Today;
        ReadRomanDeals(fDateTime, tDateTime);
    }

    public void ReadAllSimpleDeals()
    {
        DateTime fDateTime = new DateTime(1, 1, 1);
        DateTime tDateTime = DateTime.Today;
        ReadSimpleDeals(fDateTime, tDateTime);
    }

    public Dictionary<DateTime, Deal> GetAllRomanDeals()
    {
        return _deals;
    }

    public Dictionary<DateTime, Deal> GetAllSimpleDeals()
    {
        return _simpleDeals;
    }

    public void WriteAllDeals()
    {
        using (ExcelClass xls = new ExcelClass())
        {
            try
            {
                xls.OpenDocument(_quotesFileName, false);
                int i = FirstRow;
                foreach (KeyValuePair<DateTime, Deal> pair in _deals)
                {
                    string sDate = xls.GetCellStringValue(DateCol, i);
                    while (!string.IsNullOrEmpty(sDate))
                    {
                        DateTime date = StringFunctions.GetDate(sDate, DateFormat);
                        if (date.AddDays(-1) == pair.Key)
                        {
                            SetDealStops
                                    (xls, ref i, pair.Value, NewDirectionDealCol, NewOpenDealCol,
                                     NewReverseDealCol, NewProfitLostCol);
                            break;
                        }
                        i++;
                        sDate = xls.GetCellStringValue(DateCol, i);
                    }
                }
            }
            finally
            {
                xls.CloseDocumentSave();
            }
        }
    }

    public void WriteSimpleDeals()
    {
        using (ExcelClass xls = new ExcelClass())
        {
            try
            {
                _simpleDeals = new Dictionary<DateTime, Deal>();
                xls.OpenDocument(_quotesFileName, false);
                string sDate = xls.GetCellStringValue(DateCol, FirstRow);
                int i = FirstRow;
                int iOpen = i;
                Deal deal = null;
                Deal romanDeal = null;
                bool isCurrentDeal = false;
                bool isFirstDeal = true;
                decimal? stop;
                decimal? lastStop = 0;
                DateTime prevDay = new DateTime(1, 1, 1);

                foreach (KeyValuePair<DateTime, Quote> quote in _quotes)
                {
                    DateTime date = quote.Key;
                    if (!isCurrentDeal)
                    {
                        if (!_deals.ContainsKey(prevDay))
                        {
                            prevDay = date;
                            continue;
                        }


                        romanDeal = _deals[prevDay];
                        isCurrentDeal = true;
                        deal = new Deal(romanDeal.IsLong, romanDeal.OpenDate, romanDeal.OpenValue);
                    }

                    if (!isFirstDeal)
                    {
                        stop = romanDeal.GetStop(date);
                        if (stop == null)
                        {
                            deal.Close(prevDay, lastStop);
                            Quote quoteRow = _quotes[romanDeal.OpenDate];
                            int row = quoteRow.Row;
                            SetDealStops
                                    (xls, ref row, deal, SimpleDirectionDealCol, SimpleOpenDealCol,
                                     SimpleReverseDealCol, SimpleProfitLostCol);
                            _simpleDeals.Add(date, deal);
                            isCurrentDeal = false;
                        }
                        else
                        {
                            deal.SetStopReverse(date, stop);
                            if (deal.IsLong && quote.Value.Close < stop ||
                               !deal.IsLong && quote.Value.Close > stop)
                            {
                                Deal newDeal = deal.Reverse(date, quote.Value.Close);
                                Quote quoteRow = _quotes[romanDeal.OpenDate];
                                int row = quoteRow.Row;
                                SetDealStops
                                        (xls, ref row, deal, SimpleDirectionDealCol, SimpleOpenDealCol,
                                         SimpleReverseDealCol, SimpleProfitLostCol);
                                _simpleDeals.Add(date, deal);
                                deal = newDeal;
                                isCurrentDeal = false;
                            }
                        }
                        lastStop = stop;
                    }

                    prevDay = date;
                    isFirstDeal = false;
                }


            }
            finally
            {
                xls.CloseDocumentSave();
            }
        }
    }

    private void ReadRomanDeals(DateTime fromDate, DateTime toDate)
    {
        ReadDeals(ref _deals, fromDate, toDate, DirectionDealCol, OpenDealCol, ReverseDealCol);
    }

    private void ReadSimpleDeals(DateTime fromDate, DateTime toDate)
    {
        ReadDeals(ref _simpleDeals, fromDate, toDate, SimpleDirectionDealCol, SimpleOpenDealCol, SimpleReverseDealCol);
    }

    private void ReadDeals(ref Dictionary<DateTime, Deal> someDeals, DateTime fromDate, DateTime toDate, string directionDealCol, string openDealCol, string reverseDealCol)
    {
        using (ExcelClass xls = new ExcelClass())
        {
            try
            {
                someDeals = new Dictionary<DateTime, Deal>();
                xls.OpenDocument(_quotesFileName, false);
                string sDate = xls.GetCellStringValue(DateCol, FirstRow);
                int i = FirstRow;
                Deal deal = null;
                bool isFirstDeal = true;
                while (!string.IsNullOrEmpty(sDate))
                {
                    DateTime date = StringFunctions.GetDate(sDate, DateFormat);
                    if (date > fromDate && date < toDate)
                    {
                        string sDir = xls.GetCellStringValue(directionDealCol, i);
                        string sOpen = xls.GetCellStringValue(openDealCol, i);
                        string sReverse = xls.GetCellStringValue(reverseDealCol, i);
                        if (!string.IsNullOrEmpty(sDir) &&
                            !string.IsNullOrEmpty(sOpen) &&
                            !string.IsNullOrEmpty(sReverse))
                        {
                            decimal? reverse = StringFunctions.TryParseDecimal(sReverse);
                            if (isFirstDeal)
                            {
                                decimal? open = StringFunctions.TryParseDecimal(sOpen);
                                deal = new Deal(sDir, date.AddDays(-1), open);
                                deal.SetStopReverse(date, reverse);
                                isFirstDeal = false;
                            }
                            else
                            {
                                if (deal.IsSameDirection(sDir))
                                {
                                    deal.SetStopReverse(date, reverse);
                                }
                                else
                                {
                                    decimal? open = StringFunctions.TryParseDecimal(sOpen);
                                    someDeals.Add(deal.OpenDate, deal);
                                    deal = deal.Reverse(date.AddDays(-1), open);
                                    deal.SetStopReverse(date, reverse);
                                }
                            }
                        }
                    }
                    i++;
                    sDate = xls.GetCellStringValue(DateCol, i);
                }
            }
            finally
            {
                xls.CloseDocument(false);
            }
        }
    }

    private void SetDealStops(ExcelClass xls, ref int iRow, Deal deal, string directionCol, string openCol, string reverseCol, string profitLossCol)
    {
        foreach (KeyValuePair<DateTime, decimal?> stop in deal.Stops)
        {
            string sDate = xls.GetCellStringValue(DateCol, iRow);
            DateTime date = StringFunctions.GetDate(sDate, DateFormat);
            while (stop.Key != date)
            {
                iRow++;
                sDate = xls.GetCellStringValue(DateCol, iRow);
                date = StringFunctions.GetDate(sDate, DateFormat);
            }
            xls.SetCellValue(directionCol, iRow, deal.DirectionStr);
            xls.SetCellValue(openCol, iRow, deal.OpenValue.ToString());
            xls.SetCellValue(reverseCol, iRow, stop.Value.ToString());
            iRow++;
        }
        xls.SetCellValue(profitLossCol, iRow, deal.ProfitProcentStr);
    }

}

