using System.Collections.Generic;
using System.Linq;

namespace demoupper
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            //methodนี้คือรับค่าที่เป็น string collection เข้ามา และส่งค่าออกไปแบบ string collection
            //เอาตัวแปรที่รับเข้ามา มาทำเป็น 'พิมพ์ใหญ่' แล้วส่งกลับออกไป
                return text.Select(it => it.ToUpper());

            ///วนลูปตามจำนวนที่ใส่เข้ามา โดยแต่ครั้งที่วนลูปตัวอักษรแต่ละตัวจะถูกconvert
            // var input = text.ToArray();
            // for (int i = 0; i < input.Length; i++)
            // {
            //     input[i] = input[i].ToUpper();
            // }
            // return input;
        }
    }
}