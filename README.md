# GOF
设计模式学习

参照[《大话设计模式》](https://book.douban.com/subject/2334288/)学习，实现每个设计模式的案例，以及总结设计原则

同步参照网络上其他人的练习记录，争取暑假初步理解设计模式，并能简单应用

---

### 简单工厂
* 一个工厂类，一个基类，多个子类

* 用于解决对象的创建问题

* 先提供一个公共的基类，接下来的具体各类继承父类，覆写父类的提供的接口，工厂类提供一个静态方法，根据提供的参数来创建不同的类，然后通过调用工厂类来创建所需要的类

* 程序增加其他需求，则可继续继承父类创建新的类，同时在工厂类中添加对应的创建过程

* 可以理解为女娲造人，女娲表示工厂类，所有人表示基类，男人，女人，机器人表示各个子类，先提供一个人模式，然后根据女娲的想法（参数）来把这个人模型创建成相应的人类型，如果出现一种新类型的人（新增一种子类），则女娲的想法需要添加冠以这中人的信息（工厂类修改添加相应子类信息）

* 缺点是违反了开闭原则， 当对应的子类越来越多时候，工厂类会越来越臃肿，不利于维护。而且工厂类是模式的核心，一旦工厂类出现了问题，则整个模式就会崩溃

* [学习过程代码](https://github.com/Davion2017/GOF/tree/master/GOF/SimpleFactory)

![简单工厂](https://github.com/Davion2017/GOF/blob/master/GOF/Resources/Image/%E7%AE%80%E5%8D%95%E5%B7%A5%E5%8E%82.png)

---

### 策略模式
* 官方解释：
  > 它定义了算法家族，分别分装起来，让他们之间可以相互替换，此模式让算法的变化，不会影响到使用算法的客户

* 一个上下文类，一个抽象的策略类，多个具体策略

* 多个具体的策略是用来解决同一问题的不同方法，最直接形象的就是排序，可以选择冒泡排序，选择排序等等各种策略，他们的目的都是为了排序，但中间的过程不一样，如过增加一种排序算法，不会影响其他已存在的策略；还有类比的收银台，目的都是收钱，但是可以有多种收钱方式，支付宝，微信，现金，银行卡等等

* 提供给用户的是上下文类，以及各子类，创建上下文类，实例化的参数是具体的算法实例

* 缺点是用户必须提前知道所有的策略算法，而且用户需要知道上下文类，以及各子类的的区别，用户创建对象时略微麻烦（自我感觉）

* [学习过程代码](https://github.com/Davion2017/GOF/tree/master/GOF/Strategy)

![策略模式](https://github.com/Davion2017/GOF/blob/master/GOF/Resources/Image/%E7%AD%96%E7%95%A5%E6%A8%A1%E5%BC%8F.png)

---

### 装饰模式
* 官方解释：
  >动态地给给一个对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更为灵活
  
* 一个职责基类或接口，一个具体操作对象类，一个装饰抽象类，多个装饰类

* 具体对象和装饰抽象都继承自基类和接口，装饰类继承自装饰抽象类

* 具体对象的实例作为参数传递给装饰类，已装饰完的类的实例继续作为参数传递给下一装饰，直到装饰完成，最后装饰完的实例调用操作方法

* 缺点
  >创建的对象过多，容易混杂，而且似乎好多实例用完就没用了，占用内存
  
 * [学习过程代码](https://github.com/Davion2017/GOF/tree/master/GOF/Decorator)
 
 ![装饰模式](https://github.com/Davion2017/GOF/blob/master/GOF/Resources/Image/%E8%A3%85%E9%A5%B0%E6%A8%A1%E5%BC%8F.png)
 
 ---
 
 ### 代理模式
 * 官方解释：
    >为其他对象提供一种代理以控制对这个对象的访问
  
 * 一个抽象类或接口，一个实体类，一个代理类
 
 * 代理类和实体类都继承自抽象类或接口，代理类内部创建实体类的实例，然后实现与实体类的同一个方法的时候可以在之前或之后进行其他操作
 
 * 看完后第一个想法是这个模式有点类似C#里的属性的概念，在某个实例被调用某个属性时，实际内部操作的是实例私有的字段，属性提供保护安全的作用，中间通过属性作为代理来操作字段（好像略微有点不恰当）
 
 * 代理模式顾名思义就是代理的意思，和实际生活中的代理一个概念，有些商品并不由厂家直接销售，而是转交给代理商销售，代理商在销售商品时可以进行包装，打折等操作，但销售的真正的时还是厂家的商品（这么扩展的话是不是代理也可对多个对象实现代理呢，好像时动态代理的概念，再去研究一下）
 
 * 代理分类
    > * 远程代理
    >
    > * 虚拟代理
    >
    > * 安全代理
    >
    > * 智能引用代理
 * 缺点
    >暂时还不清楚
  
 * [学习过程代码](https://github.com/Davion2017/GOF/tree/master/GOF/Proxy)
 
 ![代理模式](https://github.com/Davion2017/GOF/blob/master/GOF/Resources/Image/%E4%BB%A3%E7%90%86%E6%A8%A1%E5%BC%8F.png)
