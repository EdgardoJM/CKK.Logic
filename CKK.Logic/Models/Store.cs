using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int Id;
        private string Name;
        private Product Product1;
        private Product Product2;
        private Product Product3;

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void AddStoreItem(Product prod)
        {
            if (prod == Product1)
            {
                prod = Product1;
            }
            else if (prod == Product2)
            {
                prod = Product2;
            }
            else if (prod == Product3)
            {
                prod = Product3;
            }
        }
        public void RemoveStoreItem(int productNum)
        {
            if (productNum > 0)
            {
                if (productNum == 1)
                {
                    Product1 = null;
                }
                else if (productNum == 2)
                {
                    Product2 = null;
                }
                else if (productNum == 3)
                {
                    Product3 = null;
                }
            }
        }
        public Product GetStoreItem(int productNum)
        {
            if (productNum == 1)
            {
                return Product1;
            }
            else if (productNum == 2)
            {
                return Product2;
            }
            else if (productNum == 3)
            {
                return Product3;
            }
            else
            {
                return null;
            }
        }
        public Product FindStoreItemByld(int id)
        {
            if (id == Id)
            {
                return Product1;
            }
            else if (id == Id)
            {
                return Product2;
            }
            else if (id == Id)
            {
                return Product3;
            }
            else 
            {
                return null;
            }
        }
    }
}

