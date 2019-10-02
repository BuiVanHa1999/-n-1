using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Password github : 
namespace WindowsFormsApp1
{
    public partial class Menu_DSLK : Form
    {
        public Menu_DSLK()
        {
            InitializeComponent();
        }

        public class Node
        {
            public int data;
            public Node next;
            public Node(int i)
            {
                data = i;
                next = null;
            }
        }
        public class MyList
        {
            public Node headNode;
            public MyList()
            {
                headNode = null;
            }
        }
        XemFile xf = new XemFile();
        public void Linkedlist()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*
                    foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;
                }
            }
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            Linkedlist();
            xf.ShowDialog();
        }

        
        //Them, xoa theo thu tu:
        private void BtnAddFirst_Click(object sender, EventArgs e)
        {          
             using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;
                    //Add before
                    LinkedListNode<string> nodebefore1 = lists.Find("1001      Cấu Trúc Dữ Liệu Và Giải Thuật     85000     1 ");
                    //var nodebefore = lists.AddLast("5013      Sức bền vật liệu 2                 78000     5 ");
                    lists.AddBefore(nodebefore1, "1000      Lập trình trên GPU                 150000    5 ");
                    foreach (var x in lists)
                    {
                        TextBoxReview.Text = x;
                    }
                    Text = String.Join(" ", lists);
                    TextBoxReview.Text = String.Join(" ", lists);
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Sachupdate.txt", Text);
                }
            }         
        }

        private void BtnAddBefore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;
                    //Add before
                    LinkedListNode<string> nodebefore1 = lists.Find("5010      Tin học cơ sở                      88000     5 ");
                    //var nodebefore = lists.AddLast("5013      Sức bền vật liệu 2                 78000     5 ");
                    lists.AddBefore(nodebefore1, "5013      Sức bền vật liệu 2                 78000     5 ");
                    foreach (var x in lists)
                    {
                        TextBoxReview.Text = x;
                    }
                    Text = String.Join(" ", lists);
                    TextBoxReview.Text = String.Join(" ", lists);
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Sachupdate.txt", Text);
                }
            }         
        }

        private void BtnAddAfter_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;
                    //Add before
                    LinkedListNode<string> nodebefore1 = lists.Find("5010      Tin học cơ sở                      88000     5 ");
                    //var nodebefore = lists.AddLast("5013      Sức bền vật liệu 2                 78000     5 ");
                    lists.AddAfter(nodebefore1, "5013      Sức bền vật liệu 2                 78000     5 ");
                    foreach (var x in lists)
                    {
                        TextBoxReview.Text = x;
                    }
                    Text = String.Join(" ", lists);
                    TextBoxReview.Text = String.Join(" ", lists);
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Sachupdate.txt", Text);
                }
            }
        }

        private void BtnResetReview_Click(object sender, EventArgs e)
        {
            TextBoxReview.Clear();
        }

        private void BtnAddLast_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;                                   
                    lists.AddLast("5013      Sức bền vật liệu 2                 78000     5 ");
                    foreach (var x in lists)
                    {
                        TextBoxReview.Text = x;
                    }
                    Text = String.Join(" ", lists);
                    TextBoxReview.Text = String.Join(" ", lists);
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Sachupdate.txt", Text);
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;
                    lists.Remove("4006      Trải nghiệm văn hóa ẩm thực        160000    4 ");
                    foreach (var x in lists)
                    {
                        TextBoxReview.Text = x;
                    }
                    Text = String.Join(" ", lists);
                    TextBoxReview.Text = String.Join(" ", lists);
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Sachupdate.txt", Text);
                }
            }
        }

        private void BtnRemoveFirst_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;
                    lists.Remove("1001      Cấu Trúc Dữ Liệu Và Giải Thuật     85000     1 ");
                    foreach (var x in lists)
                    {
                        TextBoxReview.Text = x;
                    }
                    Text = String.Join(" ", lists);
                    TextBoxReview.Text = String.Join(" ", lists);
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Sachupdate.txt", Text);
                }
            }
        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;
                    lists.RemoveLast();
                    foreach (var x in lists)
                    {
                        TextBoxReview.Text = x;
                    }
                    Text = String.Join(" ", lists);
                    TextBoxReview.Text = String.Join(" ", lists);
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Sachupdate.txt", Text);
                }
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    LinkedList<string> lists = new LinkedList<string>(lines);
                    /*foreach (string s in lines)
                    {
                        lists.AddLast(s);   //them dan ve sau
                    }*/
                    Text = String.Concat(lists); //Chuyen 'lists' tu dang string[] --> string
                    xf.TextBoxSach.Text = Text;
                    string temp = "5011      Sức bền vật liệu                   68000     5 ";
                    LinkedListNode<String> findnode= lists.Find(temp);
                    if(findnode != null)
                    {
                        MessageBox.Show("Node này đã được tìm thấy trong file, xem tại TextboxReview ", "Thông báo");
                        TextBoxReview.Text = findnode.Value;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy", "Lỗi");
                    }
                    /*
                    Text = String.Join(" ", lists);
                    TextBoxReview.Text = String.Join(" ", lists);
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Sachupdate.txt", Text);*/
                }
            }
        }
    }
}
