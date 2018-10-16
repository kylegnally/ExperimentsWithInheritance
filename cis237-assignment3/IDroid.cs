/***************************************************************************
 *
 * Kyle Nally
 * CIS237 T/Th 3:30pm Assignment 3 - Inheritance and Polymorphism
 * 10/16/18
 *
 ***************************************************************************/

namespace cis237_assignment3
{
    /// <summary>
    /// Interface used for creation of a Droid. Enforces inclusion of
    /// CalculateTotalCost() as a void as well as inclusion of a TotalCost
    /// property.
    /// </summary>
    interface IDroid
    {
        // Method to calculate the total cost of a droid
        void CalculateTotalCost(); 

        // Property to get the total cost of a droid
        decimal TotalCost { get; set; }
    }
}
