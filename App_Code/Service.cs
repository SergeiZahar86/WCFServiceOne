using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени класса "Service" в коде, SVC-файле и файле конфигурации.
public class Service : IService
{

    public string GetSum(string n1, string n2)
    {
        int x1, x2;
        bool flag;
        flag = int.TryParse(n1, out x1);
        if (flag == false)
        {
            return "Ошибка при конвертации числа 1";

        }
        flag = int.TryParse(n2, out x2);
        if(flag == false)
        {
            return "Ошибка при конвертации числа 2";
        }

        return (x1 + x2).ToString(); 
    }
}
