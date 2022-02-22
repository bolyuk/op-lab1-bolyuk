using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public static class DB
    {
    public static String path = "/home/danya/Projects/op-lab1-bolyuk/op-lab1-bolyuk/DB.save";
    public static List<Student> students = new List<Student>();
     
    public class Student
    {
        private String _num, _name, _info;
        public Student(String num, String name, String info) => set(num, name, info);
        public Student(String[] a) => set(g(a,0), g(a,1), g(a,2));
        public String getNum() { return _num;  }
        public String[] get() { String[] r = new string[3]; r[0] = _num; r[1] = _name; r[2] = _info; return r; }
        public void set(String num, String name, String info)
        {
            _num = num;
            _name = name;
            _info = info;
        }
    }
    static DB()
        {
        load();
        }

    public static void add(String num, String name, String info)
    {
        students.Add(new Student(num, name, info));
        save();
    }

    public static void edit(String num, String name, String info) 
    {
        for (int i = 0; i < students.Count; i++)
            if (students[i].getNum() == num) students[i].set(num, name, info);
        save();
    }

    public static void del(String num)
    {
        for (int i = 0; i < students.Count; i++)
            if (students[i].getNum() == num) students.RemoveAt(i);
        save();
    }

    public static Boolean contain(String num)
    {
        for (int i = 0; i < students.Count; i++)
            if (students[i].getNum() == num) return true;
        return false;
    }


    public static String[] search(String num)
    {
        for (int i = 0; i < students.Count; i++)
            if (students[i].getNum() == num) return students[i].get();
        return null;
    }

    public static int getCount()
    {
        return students.Count;
    }


    private static void save()
    {
        StreamWriter sw = new StreamWriter(path, true);
        for (int i=0; i< students.Count; i++)
        {
            String[] s = students[i].get();
            sw.WriteLine(s[0] +"~"+ s[1] +"~"+ s[2]);
        }
        sw.Close();

    }

    private static void load()
    {
        StreamReader sr = new StreamReader(path);
        try
        {
            students = new List<Student>();
            String[] l;
            do
            {
                l = sr.ReadLine().Split('~');
                students.Add(new Student(l));
            } while (l != null);
            Console.ReadLine();
        }catch(Exception e)
        {
            System.Console.Write(e);
        }
        finally
        {
            sr.Close();
        }
    }

    private static String g(String[] a, int i)
    {
        if (a.Length > i) return a[i]; else return "";
    }
}

