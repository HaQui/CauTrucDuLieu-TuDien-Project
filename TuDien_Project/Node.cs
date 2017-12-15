using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TuDien_Project
{
    public class Node
    {
        public string English;
        public string Vietnamese;
        public Node Left;
        public Node Right;

        public Node(string TiengAnh, string TiengViet)
        {
            English = TiengAnh;
            Vietnamese = TiengViet;
            Left = null;
            Right = null;
        }

        public bool isLeaf(ref Node node)
        {
            return (node.Right == null && node.Left == null);
        }
        public void InsertNode(ref Node node, string TiengAnh, string TiengViet)
        {
            if (node == null)
            {
                node = new Node(TiengAnh, TiengViet);
            }
            else
            {
                if (node.English.CompareTo(TiengAnh) > 0)
                {
                    InsertNode(ref node.Left, TiengAnh, TiengViet);
                }

                else
                {
                    if (node.English.CompareTo(TiengAnh) < 0)
                    {
                        InsertNode(ref node.Right, TiengAnh, TiengViet);
                    }
                }
            }
        }
        
        public void DelNode(ref Node node, string chuoi)
        {

            if (node.English.CompareTo(chuoi)>0)
            {
                DelNode(ref node.Left, chuoi);
            }
            else if(node.English.CompareTo(chuoi)<0)
            {
                DelNode(ref node.Right, chuoi);
            }
            else
            {
                Node p = node;
                if (node.Left == null)
                {
                    node = node.Right;
                }
                else
                {
                    if (node.Right == null)
                    {
                        node = node.Left;
                    }
                    else
                    {
                        thayThe(p, node.Left);
                    }
                }
                
            }
        }
        public void thayThe(Node p, Node node)
        {
            if (node.Right != null)
            {
                thayThe(p, node.Right);
            }
            else
            {
                node.English = p.English;
                node.Vietnamese = p.Vietnamese;
                p = node;
                node = node.Left;
            }
        }
        public string search(Node node, string TiengAnh)
        {
            if (node == null)
                return null;
            if (node.English.CompareTo(TiengAnh) == 0)
            {
                return node.Vietnamese;
            }
            else if (node.English.CompareTo(TiengAnh) < 0)
            {
                return search(node.Right, TiengAnh);
            }
            else if (node.English.CompareTo(TiengAnh) > 0)
            {
                return search(node.Left, TiengAnh);
            }
            return null;
        }
        public void display(Node n)
        {
            if (n == null)
                return;
            display(n.Left);
            //Console.WriteLine(n.English.ToString() + "   :   " +n.Vietnamese.ToString());
            display(n.Right);
        }
    }
}
