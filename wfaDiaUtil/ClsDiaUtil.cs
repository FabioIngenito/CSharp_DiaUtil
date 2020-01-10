using System;

namespace wfaDiaUtil
{
    public class ClsDiaUtil
    {
        /// <summary>
        /// Calcula o número de dias mínimos para que a data caia em um dia útil.
        /// </summary>
        /// <param name="nDias">Dias mínumos base para cálculo.</param>
        /// <param name="DataBase">Data do Cálculo.</param>
        /// <param name="bSoma">Adiciona ou subtrai.</param>
        /// <returns>Retorna o número de dias para cálculo.</returns>
        public static double NumeroDiasUteis(double nDias, DateTime? DataBase, bool bSoma = true)
        {
            DateTime dtFutura;
            bool bVerifica = true;

            if (DataBase.HasValue == false) DataBase = DateTime.Now;

            while (bVerifica)
            {
                dtFutura = Convert.ToDateTime(DataBase).AddDays(nDias);

                if (EhFeriadoFinalDeSemana(dtFutura))
                {
                    if (bSoma == true)
                        nDias += 1;
                    else
                        nDias -= 1;
                }
                else
                    bVerifica = false;
            }

            return nDias;
        }

        /// <summary>
        /// Essa função pode ser substituída por uma consulta a uma base de dados.
        /// </summary>
        /// <param name="dtEntrada">Data a ser verificada.</param>
        /// <returns>Retorna verdadeiro ou falso.</returns>
        private static bool EhFeriadoFinalDeSemana(DateTime dtEntrada)
        {
            // Sabadão
            if (dtEntrada.DayOfWeek == DayOfWeek.Saturday)
                return true;

            // Domingueira
            if (dtEntrada.DayOfWeek == DayOfWeek.Sunday)
                return true;

            // Dias felizes.... (feriados)
            switch (dtEntrada.ToString("dd/MM/yyyy"))
            {
                case "01/01/2012":
                case "01/01/2013":
                case "01/01/2014":
                case "01/01/2015":
                case "01/01/2016":
                case "01/01/2017":
                case "01/01/2018":
                case "01/01/2019":
                case "01/01/2020":
                case "01/01/2021":
                case "01/01/2022":
                case "01/01/2023":
                case "01/01/2024":
                case "01/01/2025":
                case "01/01/2026":
                case "01/01/2027":
                case "01/01/2028":
                case "01/01/2029":
                case "01/01/2030":
                case "01/03/2022":
                case "01/05/2012":
                case "01/05/2013":
                case "01/05/2014":
                case "01/05/2015":
                case "01/05/2016":
                case "01/05/2017":
                case "01/05/2018":
                case "01/05/2019":
                case "01/05/2020":
                case "01/05/2021":
                case "01/05/2022":
                case "01/05/2023":
                case "01/05/2024":
                case "01/05/2025":
                case "01/05/2026":
                case "01/05/2027":
                case "01/05/2028":
                case "01/05/2029":
                case "01/05/2030":
                case "02/04/2021":
                case "02/11/2011":
                case "02/11/2012":
                case "02/11/2013":
                case "02/11/2014":
                case "02/11/2015":
                case "02/11/2016":
                case "02/11/2017":
                case "02/11/2018":
                case "02/11/2019":
                case "02/11/2020":
                case "02/11/2021":
                case "02/11/2022":
                case "02/11/2023":
                case "02/11/2024":
                case "02/11/2025":
                case "02/11/2026":
                case "02/11/2027":
                case "02/11/2028":
                case "02/11/2029":
                case "02/11/2030":
                case "03/03/2014":
                case "03/03/2025":
                case "03/04/2015":
                case "03/04/2026":
                case "03/06/2021":
                case "04/03/2014":
                case "04/03/2019":
                case "04/03/2025":
                case "04/03/2030":
                case "04/06/2015":
                case "04/06/2026":
                case "05/03/2019":
                case "05/03/2030":
                case "06/04/2012":
                case "07/04/2023":
                case "07/06/2012":
                case "07/09/2012":
                case "07/09/2013":
                case "07/09/2014":
                case "07/09/2015":
                case "07/09/2016":
                case "07/09/2017":
                case "07/09/2018":
                case "07/09/2019":
                case "07/09/2020":
                case "07/09/2021":
                case "07/09/2022":
                case "07/09/2023":
                case "07/09/2024":
                case "07/09/2025":
                case "07/09/2026":
                case "07/09/2027":
                case "07/09/2028":
                case "07/09/2029":
                case "07/09/2030":
                case "08/02/2016":
                case "08/02/2027":
                case "08/06/2023":
                case "09/02/2016":
                case "09/02/2027":
                case "09/07/2013":
                case "09/07/2014":
                case "09/07/2015":
                case "09/07/2016":
                case "09/07/2017":
                case "09/07/2018":
                case "09/07/2019":
                case "09/07/2020":
                case "09/07/2021":
                case "09/07/2022":
                case "09/07/2023":
                case "09/07/2024":
                case "09/07/2025":
                case "09/07/2026":
                case "09/07/2027":
                case "09/07/2028":
                case "09/07/2029":
                case "09/07/2030":
                case "10/04/2020":
                case "11/02/2013":
                case "11/06/2020":
                case "12/02/2013":
                case "12/02/2018":
                case "12/02/2024":
                case "12/02/2029":
                case "12/10/2012":
                case "12/10/2013":
                case "12/10/2014":
                case "12/10/2015":
                case "12/10/2016":
                case "12/10/2017":
                case "12/10/2018":
                case "12/10/2019":
                case "12/10/2020":
                case "12/10/2021":
                case "12/10/2022":
                case "12/10/2023":
                case "12/10/2024":
                case "12/10/2025":
                case "12/10/2026":
                case "12/10/2027":
                case "12/10/2028":
                case "12/10/2029":
                case "12/10/2030":
                case "13/02/2018":
                case "13/02/2024":
                case "13/02/2029":
                case "13/06/2012":
                case "13/06/2013":
                case "13/06/2014":
                case "13/06/2015":
                case "13/06/2016":
                case "13/06/2017":
                case "13/06/2018":
                case "13/06/2019":
                case "13/06/2020":
                case "13/06/2021":
                case "13/06/2022":
                case "13/06/2023":
                case "13/06/2024":
                case "13/06/2025":
                case "13/06/2026":
                case "13/06/2027":
                case "13/06/2028":
                case "13/06/2029":
                case "13/06/2030":
                case "14/04/2017":
                case "14/04/2028":
                case "15/02/2021":
                case "15/04/2022":
                case "15/06/2017":
                case "15/06/2028":
                case "15/11/2011":
                case "15/11/2012":
                case "15/11/2013":
                case "15/11/2014":
                case "15/11/2015":
                case "15/11/2016":
                case "15/11/2017":
                case "15/11/2018":
                case "15/11/2019":
                case "15/11/2020":
                case "15/11/2021":
                case "15/11/2022":
                case "15/11/2023":
                case "15/11/2024":
                case "15/11/2025":
                case "15/11/2026":
                case "15/11/2027":
                case "15/11/2028":
                case "15/11/2029":
                case "15/11/2030":
                case "16/02/2015":
                case "16/02/2021":
                case "16/02/2026":
                case "16/06/2022":
                case "17/02/2015":
                case "17/02/2026":
                case "18/04/2014":
                case "18/04/2025":
                case "19/04/2019":
                case "19/04/2030":
                case "19/06/2014":
                case "19/06/2025":
                case "20/02/2012":
                case "20/02/2023":
                case "20/06/2019":
                case "20/06/2030":
                case "21/02/2012":
                case "21/02/2023":
                case "21/04/2012":
                case "21/04/2013":
                case "21/04/2014":
                case "21/04/2015":
                case "21/04/2016":
                case "21/04/2017":
                case "21/04/2018":
                case "21/04/2019":
                case "21/04/2020":
                case "21/04/2021":
                case "21/04/2022":
                case "21/04/2023":
                case "21/04/2024":
                case "21/04/2025":
                case "21/04/2026":
                case "21/04/2027":
                case "21/04/2028":
                case "21/04/2029":
                case "21/04/2030":
                case "24/02/2020":
                case "25/02/2020":
                case "25/03/2016":
                case "25/12/2012":
                case "25/12/2013":
                case "25/12/2014":
                case "25/12/2015":
                case "25/12/2016":
                case "25/12/2017":
                case "25/12/2018":
                case "25/12/2019":
                case "25/12/2020":
                case "25/12/2021":
                case "25/12/2022":
                case "25/12/2023":
                case "25/12/2024":
                case "25/12/2025":
                case "25/12/2026":
                case "25/12/2027":
                case "25/12/2028":
                case "25/12/2029":
                case "25/12/2030":
                case "26/03/2027":
                case "26/05/2016":
                case "27/02/2017":
                case "27/05/2027":
                case "28/02/2017":
                case "28/02/2022":
                case "28/02/2028":
                case "29/02/2028":
                case "29/03/2013":
                case "29/03/2024":
                case "30/03/2018":
                case "30/03/2029":
                case "30/05/2013":
                case "30/05/2024":
                case "31/05/2018":
                case "31/05/2029":
                case "31/12/2020":
                case "31/12/2021":
                case "31/12/2024":
                case "31/12/2025":
                case "31/12/2026":
                case "31/12/2027":
                case "31/12/2029":
                case "31/12/2030":
                    {
                        return true;
                    }
            }

            // Dia util, que triste...
            return false; // tudo ok!
        }
    }
}
