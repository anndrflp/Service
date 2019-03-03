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

        static public String GetConstantTraductionAdConstantsStatus(String prTableName, int prHandle, String prFormName)
        {
            int vConstant = TableControl.GetStatus(prTableName, prHandle);
            String vTraduction = "";

            if (vConstant == AdConstants.AdConstantsStatus.Registered)
            {
                vTraduction = " - Registrado";
            }

            if (vConstant == AdConstants.AdConstantsStatus.AwModification)
            {
                vTraduction = " - Ag. modificações";
            }

            if (vConstant == AdConstants.AdConstantsStatus.Active)
            {
                vTraduction = " - Ativo";
            }

            if (vConstant == AdConstants.AdConstantsStatus.Canceled)
            {
                vTraduction = " - Cancelado";
            }

            return prFormName + vTraduction;
        }
    }
}
