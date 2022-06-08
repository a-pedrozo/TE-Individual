using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// This is a sample class to illustrate the syntax we see in classes
    /// </summary>
    public class SampleClass : object //, ISomeInterface, IAnotherInterface
    {
        // Constructors

        // Constructors are special methods called to create the class
        // They are almost always public
        // Constructors must call ONE base constructor
        // If you don't specify which base constructor, C# assumes base()
        // This particular constructor is one that is auto-generated if you have no constructors
        // declared at all
        public SampleClass() : base() 
        {
        }

        // This is an overloaded constructor. It's another option for creating the class
        // This one requires a favorite number.
        public SampleClass(int favoriteNumber) 
            : base()
        {
            this.FavoriteNumber = favoriteNumber;
        }

        // Fields (or class variables)
        // This belongs to the class
        // This can be used in any method or property (including constructor)
        // This is typically private
        // Fields don't have get or set
        private List<int> golfScores = new List<int>();

        // Properties - Noun names

        // This is a name property of type string.
        // Anything outside of the class can get or set it
        // Properties are PascalCased and almost always public
        public string Name { get; set; }

        // This is an int property. It can be read outside the class
        // But only set inside the class (because private)
        public int Id { get; private set; }

        // Derived property (or calculated property) (or computed property)
        // These are calculated every time something says mySampleClass.CurrentDay
        // These never have a setter
        // These should always have a return inside of the get {}
        // Note: there is no ; after the get
        public DateTime CurrentDay
        {
            get
            {
                return DateTime.Today;
            }
        }

        // A get-only property. This can ONLY be set at class creation
        // You set this either inline OR in the constructor
        // You cannot set this anywhere else
        public int FavoriteNumber { get; } = 42; // Sets this to 42 on creation

        // Constants are primitive values that do not change
        private const decimal TicketPrice = 59.99m;

        // Methods

        // This is a method. It does stuff.
        // Methods MAY have a return type or may return void
        // Methods MAY have parameters
        // Methods start with a verb
        // Methods are PascalCased
        public void DoStuff()
        {
            // Stuff is done here

            // NOTE: No return statement required in a void method. But you may return;
            return;
        }

        // Methods may be OVERLOADED and have different versions with the same name
        // But different parameter types
        public void DoStuff(int numberOfTimes)
        {

        }

        // Methods may return things
        public bool CalculateDotNetIsAwesome()
        {
            return true; // When we say return, the method stops evaluating after that

            Console.WriteLine("This line will never be reached");

            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
