namespace DZ_03
{
    internal class User
    {
        // PROPERTIES

        public string FirstName { get; set; }
        public string LastName { get; set; }
        // USING OF KEYWORD init TO INITIALIZE Age PROPERTY ONLY ONCE, AND THEN MAKE IT immutable.
        public byte Age { get; init; }
        // THE CREATION OF Gender PROPERTY WHICH CORRESPONDS TO enum UserGender TYPE.
        public UserGender Gender { get; set; }

        // CONSTRUCTORS

        // DEFAULT CONSTRUCTOR WITHOUT PARAMETERS.
        public User()
        {
            Console.WriteLine("THE DEFAULT CONSTRUCTOR OF User INITIALIZED!");
        }

        // CONSTRUCTOR WICH SETUPS Age PROPERTY.
        [SetsRequiredMembers]    // PARAMETER THAT USED CONFIGURE CONSTRUCTOR TO SHOW THAT SETUP AGE WITH DEFAULT VALUE WILL BE DONE IN ANY CASE, AND THAT BECAUSE CALLER IS NOT FORCED TO ASSIGN VALUE ON COMPILATION STAGE... :S AT LEAST AS I HAVE UNDERSTAND.
        public User(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;     // ASSIGN PROPERTY Age VIA CONSTRUCTOR METHOD.
        }
    }

    // THE enum TYPE IS INITIALIZED, IT CONNECTS TO THE User CLASS.
    enum UserGender : byte
    {
        Male = 0,
        Female = 1,
        Unknown = 2
    }
}