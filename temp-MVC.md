## MVC教程笔记

### 传统表达式与lambda表达式
``` C#
//EF对象
EFFristModelEntities db = new EFFristModelEntities();

//传统写法
 var uInfoList = from u in db.UserInfo
                  where u.ID == 343
                  select new {UName=u.UserName,UPwd=u.UserPass};

//lambda 写法
 var uInfoList = db.UserInfo.Where<userInfo>(u=>u.ID==343);
```

### 分页

``` C#
 //高效分页
 int pageIndex = 2;
 int page size = 2;
 var uInfoList = db.UserInfo.Where<UserInfo>(u=>true).OrderByDescending(u=>u.ID).Skip<UserInfo>((pageIndex-1)*pagesize).Take<UserInfo>(pagesize);//Skip:表示跳过多少条记录，Take表示取多少条记录
 
 foreach(var userinfo in uInfoList)
 {
    Response.Write(UserInfo.UserName);
 }
```

## 对象模式
> * 单例模式 ： 整个应用程序中对象只有一个实例
> * 线程唯一 ：对象在各层函数调用中唯一
