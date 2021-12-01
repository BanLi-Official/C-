using System;

class person {

    //第一种单例化开发形式
    #region
    /*
    private person() { }//将构造函数收为私有
    private static person a = new person(); //用静态变量让person只在内存中加载一次
    public static person getperson() {//提供一个接口让外界访问这个类
        return a;
    }

    //用属性来实现
    public static person getperson2
    {
        get { return a; }
    }*/
    #endregion

    //第二种单例化开发形式
    #region
    /*
    private person() { }
    private static person a;
    public static person getperson() {
        //什么时候需要就什么时候进行实例化
        if (a == null) a = new person();
        return a;
    }

    public static person getperson2
    {
        get {
            if (a == null) a = new person();
            return a;
        }
    }*/
    #endregion

    //第三种单例化开发形式
    private person() { }
    public readonly static person a = new person(); 
}

class program {
    public static void Main(String[] args)
    {
        /*
        person a1 = person.getperson();
        person a2 = person.getperson();
        person a3 = person.getperson2;
        Console.WriteLine((a1 == a2&&a2==a3));
        */

        person a1 = person.a;
        person a2 = person.a;
        Console.WriteLine((a1 == a2 ));

    }
}
