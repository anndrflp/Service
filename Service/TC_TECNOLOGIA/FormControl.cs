using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Constants;
namespace Service.CONTROL.Menu
{
    static class FormControl
    {
        // Passar a tabela e o handle do registro.

        static public Boolean canRegister(int prStatus)
        {
            return prStatus == 0;
        }

        static public Boolean canActive(int prStatus)
        {
            return (prStatus == AdConstants.AdConstantsStatus.AwModification) || (prStatus == AdConstants.AdConstantsStatus.Registered);
        }

        static public Boolean canReturn(int prStatus)
        {
            return (prStatus == AdConstants.AdConstantsStatus.Active);
        }

        static public Boolean canCancel(int prStatus)
        {
            return (prStatus == AdConstants.AdConstantsStatus.AwModification);
        }

        static public Boolean canExclude(int prStatus)
        {
            return (prStatus == AdConstants.AdConstantsStatus.Registered);
        }

        static public Boolean canAlter(int prStatus)
        {
            return (prStatus == AdConstants.AdConstantsStatus.AwModification) || (prStatus == AdConstants.AdConstantsStatus.Registered);
        }

        static public Boolean canAlterChild(String prTableName, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            return (vStatus == AdConstants.AdConstantsStatus.AwModification) || (vStatus == AdConstants.AdConstantsStatus.Registered);
        }

        static public String GetConstantTranslationAdConstantsStatus(int prValue)
        {
            String vTranslation = "";

            if (prValue == AdConstants.AdConstantsStatus.Registered)
            {
                vTranslation = " - Registrado";
            }

            if (prValue == AdConstants.AdConstantsStatus.AwModification)
            {
                vTranslation = " - Ag. modificações";
            }

            if (prValue == AdConstants.AdConstantsStatus.Active)
            {
                vTranslation = " - Ativo";
            }

            if (prValue == AdConstants.AdConstantsStatus.Canceled)
            {
                vTranslation = " - Cancelado";
            }

            return vTranslation;
        }
    }
}
