using System.Globalization;

namespace OHCE.Console
{
    internal class SystemLangue : ILangue
    {

        public string ISOLanguage = CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;

        /// <inheritdoc />
        public string BienDit => GetBienDit();

        /// <inheritdoc />
        public string DireBonjour(MomentJournee moment)
        {
            if (ISOLanguage == "fr")
            {
                if (moment == MomentJournee.Soir || moment == MomentJournee.Nuit)
                {
                    return Expressions.Français.Bonsoir;
                }
                else
                {
                    return Expressions.Français.Bonjour;
                }
            }
            else if (ISOLanguage == "en")
            {
                if (moment == MomentJournee.Soir || moment == MomentJournee.Nuit)
                {
                    return Expressions.English.Bonsoir;
                }
                else
                {
                    return Expressions.English.Bonjour;
                }
            }
            else
            {
                if (moment == MomentJournee.Soir || moment == MomentJournee.Nuit)
                {
                    return Expressions.English.Bonsoir;
                }
                else
                {
                    return Expressions.English.Bonjour;
                }
            }
        }

        /// <inheritdoc />
        public string AuRevoir => GetAuRevoir();

        public string InputPalindrome => GetPalindrome();

        public string GetBienDit()
        {
            if (ISOLanguage == "fr")
            {
                return Expressions.Français.BienDit;
            }
            else if (ISOLanguage == "en")
            {
                return Expressions.English.BienDit;
            }
            else
            {
                return Expressions.English.BienDit;
            }
        }

        public string GetAuRevoir()
        {
            if (ISOLanguage == "fr")
            {
                return Expressions.Français.AuRevoir;
            }
            else if (ISOLanguage == "en")
            {
                return Expressions.English.AuRevoir;
            }
            else
            {
                return Expressions.English.AuRevoir;
            }
        }

        public string AuRevoirBis(MomentJournee moment)
        {
            if (ISOLanguage == "fr")
            {
                if (moment == MomentJournee.Soir || moment == MomentJournee.Nuit)
                {
                    return Expressions.Français.AuRevoir;
                }
                else
                {
                    return Expressions.Français.BonneJournee;
                }
            }
            else if (ISOLanguage == "en")
            {
                if (moment == MomentJournee.Soir || moment == MomentJournee.Nuit)
                {
                    return Expressions.English.AuRevoir;
                }
                else
                {
                    return Expressions.English.BonneJournee;
                }
            }
            else
            {
                if (moment == MomentJournee.Soir || moment == MomentJournee.Nuit)
                {
                    return Expressions.English.AuRevoir;
                }
                else
                {
                    return Expressions.English.BonneJournee;
                }
            }
        }

        public string GetPalindrome()
        {
            if (ISOLanguage == "fr")
            {
                return Expressions.Français.InputPalindrome;
            }
            else if (ISOLanguage == "en")
            {
                return Expressions.English.InputPalindrome;
            }
            else
            {
                return Expressions.English.InputPalindrome;
            }
        }
    }
}
