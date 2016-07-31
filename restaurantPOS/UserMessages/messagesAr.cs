using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantPOS.userMessages
{
    class messagesAr
    {
        

        public string ErrorMessae = "خطأ : من فضلك ادخل ";

        public string insertedError = "خطأ, لم يتم الحفظ";

        public string insertedSuccessfully = "تم الحفظ بنجاح";

        public string deleteConfirm = "هل انت متأكد من الحذف";

        public string deletedError = "خطأ, لم يتم الحذف";

        public string deletedSuccessfully = "تم الحذف بنجاح";

        public string updatedError = "خطأ, لم يتم التعديل";

        public string updatedSuccessfully = "تم التعديل بنجاح";

        public string connectionError = "cannot open connection";

        public string fontsError = "Error, Fonts Not Found!!";

        public string loginError = "خطأ, من فضلك ادخل اسم المستخدم و الرقم السرى بشكل صحيح";

        public string chooseRow = " خطأ, من فضلك اختر البيان اولا أو ربما هذا البيان مرتبط بعمليات اخرى";

        #region authAndUsers
        public string emptyGroupName = "الرجاء ادخال اسم المجموعة";
        public string chooseGroupAuth = "الرجاء اختيار صلاحيات المجموعة";
        public string authError = "خطأ, ليس لديك صلاحيات";
        #endregion

        #region clients
        public string chooseClientRow = "خطأ, من فضلك اختار العميل اولا";
        #endregion

        #region units
        public string chooseUnitRow = "خطأ, من فضلك اختر الوحدة اولا";
        public string fillUnits = "خطأ, من فضلك قم بتعبئة الوحدات اولا";
        public string errorFillUnits = "خطأ فى تعبئة الوحدات";
        #endregion

        #region items
        public string itemDetail = "خطأ, من فضلط ادخل بيانات الصنف";
        #endregion
    }
}
