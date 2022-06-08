using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{   /// <summary>
    /// this is a sample class to illustrate the syntax we see in classes 
    /// </summary>
   public  class SampleClass : Object //ISomeInterfface, IAnotherInterface this is where parent classes or interfaces go 
    {
        //Constructors are special methods called to create the class
        // this particular constructo is one that is auto-generated if you have no constructors declared at all
        // Constructors must call ONE base constructor 
        // if you dont specifiy which base constructor, C# assumes base()
        // constuctor is a special kind of method 
        
               
        public SampleClass() : base()
        {

        }
        //this is an overloaded constructor (more than one method/constructor). its another option for creating the class
        //this one requires a favorite number 
        public SampleClass(int favoriteNum) : base()
        {

        }

        // porperties - noun names 

        // Fileds (or class variables)
        // this belongs to the class
        // this can be used in any method or property (including constructor
        // this is typically private
        // fields dont have get or set
        private List<int> golfScores = new List<int>();


        public string Name { get; set; }
        // this is a name property of type string
        // anything outside of the clas can get or set it
        // properties are PascalCased and almost always public 

        public int ID { get; private set; }
        // this property is and int and private 
        // can be read outside the classs 
        // but only set inside class because it's private 


        // this is a derived property 
        // these are calculated everything something says mySampleClass.CurrentDay
        // these never have a setter and should always have a return in the get {}
        
        public DateTime CurrentyDay
        {
            get
            {
                return DateTime.Today;
            }
        }

        // a get only property. this can ONLY be set at class creating 
        // you set either inline OR in the constructor
        // cannot set this anywhere else
        public int FavoriteNum { get; } = 42;

        //Constants are primitave values that do not change 
        // private makes it only called inside this classs
        private const decimal TicketPrice = 59.99m;


        //Methods 
        // this is a method performs action aka do stuff
        // methods MAY have a return type or may return void 
        // methods may have parameters 
        // methods start with a verb 
        // methods are PascalCased
        // methods should start with verb 

        public void DoStuff()
        {
            // perform logic 
            // this particular method is void and does not return anything
        }

        //methods maybe OVERLOADERD and have different version with the same name but different types 
        
        public void Dostuff(int numberOfTimes)
        {
           
        }

        public bool CalculatedDotNetAwesome()
        {
            return true; // when says return, method stops evaluating 

            
        }

        public override string ToString() // cannot change paramerts only return 
        {
            return Name;
        }
    }
}
