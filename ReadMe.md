#关于本项目
##1.背景：
大部分的DHT爬虫都是使用Python等脚本来写的，而使用C#来实现的很少，为了填补之方面的空缺，同时也为了自己学习下相关的知识，就准备写个用C#实现的。
##2.特点：
只需要开机，不需要登录到桌面，就可以通过Windows系统服务来启动并抓取。
##3.功能模块：
主要分三大块：
```
DHTServer：Windows系统服务
DHTClient：参数设置主程序
DHTWeb：WEB网站
```
另外有几个核心部分：
```
DHTCore：通用的核心处理模块
DHTSQLCore：数据库处理模块
DHTSQLHelper：数据库助手（这里使用的是PetaPoco，感谢该作者及其开源精神）
```

##4.开源
本代码开源，自己的水平也很弱，对于WinForm及Windows Service和常用的多线程等一点也不会，而且很困惑，在这里请大家批评指正提拔，谢谢。