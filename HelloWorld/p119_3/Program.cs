/*
1. 미니 쇼핑카트를 구현하세요.

장바구니의 구조가 다음과 같다.

CartNo 상품코드 상품명  단가 수량 합계금액
------------------------------------------------------------- 
1      1001      볼펜    1000      2      2000 
2      1002      연필      500      3      1500 
3      1003      딸기      6000    2      12000 


Cart 클래스를 구현하고,
HashTable, Dictionary<T> 제너릭을 이용하여 장바구니를 구현해 보세요...
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Dictionary item = new Hashtable();
            item.Add("볼펜");
            item.Add("연필");
            item.Add("딸기");

            SortedList s = new SortedList(item);

            foreach(DictionaryEntry i in s)
            {
                Console.WriteLine("Key = {0}, Value = {1}", i.Key, i.Value);
            }
        }
    }
}