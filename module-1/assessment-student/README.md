# Module 1 Assessment Exercise

The assessment helps you validate your understanding of the module one objectives:
* Variables and data types 
* Conditional and iteration logic 
* Object-Oriented Programming 
* Unit Testing 

It also gives you practice with coding assessments you may encounter during the job interview process.

## Overview

This is a time-boxed, individual coding assessment. You have **one hour** to complete the assessment. Complete **as much as you can** of the assessment during that time.

You may use any reference materials, documentation, or online search available as long as the effort remains an individual effort.

Whatever you submit **should not have compile or run-time errors**. Features that are completed should run successfully to receive credit. Any unit tests you write should be error-free and turn green.

If you are nearing the end of the assessment and you have compile/run-time errors, consider commenting out or removing the code that causes the errors.

At the end of the assessment, you should push your final project to your repository.

If you finish before the end of the hour, please be respectful of those still working. 

We understand this assessment can be difficult and may trigger anxiety, but this exists to give you an early look at where you are in a real-world programming scenario.

## Instructions

1. Open the project in the `assessment-student` subdirectory.
2. You should see the typical folder structure for a project with a skeleton application program `Main()` method.
3. Any files you create should be placed in the correct folders within the project.
4. Be sure to push your project when you are done or at the end of the assessment.
5. Your instructor will tell you when to begin and give you a "10-minute warning" before the end of the time-box.

# Amusement Park Tickets

1. Create a new class that represents a *Ticket Purchase* at an amusement park.
2. Add the following properties to the ticket purchase class: *Note: Use the appropriate C# naming / capitalization conventions for property names*
    * `name`: indicates the name of the person purchasing the tickets. This should **not** have a public setter.
    * `number of tickets`: indicates how many tickets are being purchased.  This should **not** have a public setter.
    * `base price`: Indicates the base price of the purchase. This should be `number of tickets` times $59.99. This should be a derived property and should not have a setter.
3. Create a constructor that accepts `name` and `number of tickets`.
4. Create a method that calculates the total price with surcharges using two `bool` input parameters: `earlyCheckIn` and `priorityRideAccess`:
    * The price should start at the value of the `base price` derived property but two surcharges may be applied.
    * If `earlyCheckIn` is true, an added charge of $10 per ticket should be applied.
    * If `priorityRideAccess` is true, an added charge of $50 per ticket should be applied.
    * It is possible for both `earlyCheckIn` and `priorityRideAccess` to be applied.
5. Instantiate an instance of this class in `Main()` and store it in a variable.
6. Call the method you made in step 4 on the variable you made in step 5 and store the result in a variable.
    * You do not need to get any user input for this step. Feel free to pass in hard-coded values for any parameters provided.
7. Override the `ToString()` method for the ticket purchase and have it return `"TICKET - {name} - {base price}"` where `{name}` and `{base price}` are placeholders for the actual values from the object's properties. You will not need to call the method from step 4 for this step.
8. In `Main()` test the `ToString` method of your class by writing its value to the console.
9. CHALLENGE: Implement unit tests to validate the functionality of:
    * The calculate total price method defined in step 4
    * The base total derived property
    * The ticket purchase constructor