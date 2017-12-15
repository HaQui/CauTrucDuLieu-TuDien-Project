using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuDien_Project
{
    public class BinarySearchTree
    {
        public Node Root;
        public int count;

        public BinarySearchTree()
        {
            count = 0;
            Root = null;
        }

        public void del(string chuoi)
        {
            {
                Root.DelNode(ref Root, chuoi);
            }
        }
        public void Insert(string TiengAnh, string TiengViet)
        {
            if (isEmpty())
            {
                Root = new Node(TiengAnh, TiengViet);
            }
            else
            {
                Root.InsertNode(ref Root, TiengAnh, TiengViet);
            }
            count++;
        }
        public string search(string sTiengAnh)
        {
            return Root.search(Root, sTiengAnh);
        }
        public bool isLeaf()
        {
            if (!isEmpty())
                return Root.isLeaf(ref Root);
            return true;
        }
        public void display()
        {
            if (!isEmpty())
            {
                Root.display(Root);
            }
        }
        public bool isEmpty()
        {
            return Root == null;
        }
        public int Count()
        {
            return count;
        }
    }
}
