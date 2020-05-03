using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HomeWork2_Storage_
{
    public class InputOject
    {
        public int elementNumber { get; set; }
        public string value { get; set; }
        public override bool Equals(object obj)
        {
            InputOject convertedObj = obj as InputOject;
            
            return convertedObj != null && convertedObj.elementNumber == elementNumber && (convertedObj.value?.Equals(value) ?? value == null);
        }
        public override int GetHashCode()
        {
            return (elementNumber.GetHashCode()/2) + ((value?.GetHashCode() ?? typeof(string).GetHashCode())/2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            MyStorage<InputOject> list = new MyStorage<InputOject>()
            {

                new InputOject() { elementNumber = 1, value = "asdf" },
                new InputOject() { elementNumber = 2, value = "qwerq" },
                new InputOject() { elementNumber = 3, value = "jkgh" }
            };
        
            foreach (var item in list)
            {
                Console.WriteLine(item.elementNumber + item.value);
            }

            Console.WriteLine($"Number of elements {list.Count}");
            
            list.Delete(new InputOject() { elementNumber = 2, value = "qwerq" });

            Console.WriteLine($"Number of elements after Delete {list.Count}");

            foreach (var item in list)
            {
                Console.WriteLine(item.elementNumber + item.value);
            }
            Console.ReadLine();
        }
    }
}
