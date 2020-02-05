## C#基础
* [抽象类](C#/Abstract_Class.cs)

* [结构体](/C#/DateTime_Struct.cs)

* [简单委托](/C#/First_Delegate.cs)

* [简单接口](/C#/First_Interface.cs)

* [泛型类](/C#/Generic_Class.cs)

* [多线程](/C#/Test_Thread.cs)

* [二进制序列化](/C#/Binary_Serialization.cs)


## ADO.NET
* SqlConnecton、SqlCommand、SqlAdapter、SqlDataReader、DataSet [简单示例](/simple_ADO.NET.cs)

## LINQ
* [简单LINQ](/Simple_LINQ.cs)

![Simple_LINQ](/Image/Simple_LINQ.png)

## Javascript

> 在 JavaScript 中，没有值的变量，其值是 undefined。typeof 也返回 undefined。
Undefined 与 null 的值相等，但类型不相等：
``` javascript
typeof undefined              // undefined
typeof null                   // object
null === undefined            // false
null == undefined             // true
```
JavaScript 拥有动态类型。这意味着相同变量可用作不同类型:
``` JavaScript
var x;               // 现在 x 是 undefined
var x = 7;           // 现在 x 是数值
var x = "Bill";      // 现在 x 是字符串值
```

JavaScript 变量能够保存多种数据类型：数值、字符串值、数组、对象等等：
``` javascript
var length = 7;                             // 数字
var lastName = "Gates";                      // 字符串
var cars = ["Porsche", "Volvo", "BMW"];         // 数组
var x = {firstName:"Bill", lastName:"Gates"};    // 对象 
```

JavaScript 对象用花括号来书写。
对象属性是 *name:value* 对，由逗号分隔。
``` javascript
var person = {
   firstName:"Bill", 
   lastName:"Gates", 
   age:62, 
   eyeColor:"blue",
   fullName : function() { //对象方法
    return this.firstName + " " + this.lastName;
    }
  };
  
//调用对象方法
person.fullName() //不带括号返回函数定义
```
