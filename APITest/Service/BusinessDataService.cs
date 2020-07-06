using APITest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Service
{
    public class BusinessDataService : IBusinessDataService
    {
        public User UserDataConversion(User userModel)
        {
            User convertData = new User();

            convertData.FillName = stringReverse(userModel.FillName);
            convertData.Email = stringReverse(userModel.Email);
            convertData.PhoneNumber = String.IsNullOrEmpty(userModel.PhoneNumber) ? userModel.PhoneNumber : stringReverse(userModel.PhoneNumber.ToString());
            convertData.Notes = String.IsNullOrEmpty(userModel.Notes) ? userModel.Notes : stringReverse(userModel.Notes);

            return convertData;
        }

        public string stringReverse(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
    }
}
