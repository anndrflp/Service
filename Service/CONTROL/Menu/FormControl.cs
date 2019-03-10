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

        static public Boolean canRegister(String prTableName, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            return vStatus == 0;
        }

        static public Boolean canActive(String prTableName, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            return (vStatus == AdConstants.AdConstantsStatus.AwModification) || (vStatus == AdConstants.AdConstantsStatus.Registered);
        }

        static public Boolean canReturn(String prTableName, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            return (vStatus == AdConstants.AdConstantsStatus.Active);
        }

        static public Boolean canCancel(String prTableName, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            return (vStatus == AdConstants.AdConstantsStatus.AwModification);
        }

        static public Boolean canExclude(String prTableName, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            return (vStatus == AdConstants.AdConstantsStatus.Registered);
        }

        static public Boolean canAlter(String prTableName, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            return (vStatus == AdConstants.AdConstantsStatus.AwModification) || (vStatus == AdConstants.AdConstantsStatus.Registered);
        }

        static public Boolean canAlterChild(String prTableName, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            return (vStatus == AdConstants.AdConstantsStatus.AwModification) || (vStatus == AdConstants.AdConstantsStatus.Registered);
        }

        static public String GetConstantTranslationAdConstantsStatus(String prTableName, int prHandle, String prFormName)
        {
            int vConstant = TableControl.GetStatus(prTableName, prHandle);
            String vTranslation = "";

            if (vConstant == AdConstants.AdConstantsStatus.Registered)
            {
                vTranslation = " - Registrado";
            }

            if (vConstant == AdConstants.AdConstantsStatus.AwModification)
            {
                vTranslation = " - Ag. modificações";
            }

            if (vConstant == AdConstants.AdConstantsStatus.Active)
            {
                vTranslation = " - Ativo";
            }

            if (vConstant == AdConstants.AdConstantsStatus.Canceled)
            {
                vTranslation = " - Cancelado";
            }

            return prFormName + vTranslation;
        }
    }
}
