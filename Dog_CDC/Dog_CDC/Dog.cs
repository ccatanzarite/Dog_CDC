using System;
/**
 * This class models a Dog
 * @author Clayton Catanzarite
 * @version 1.0
 */
namespace Dog_CDC
{
    public class Dog
    {
        private int age;
        private String name;
        
        public Dog()
        {
            age = 0;
            name = "";
        }
        public Dog(int age, String name)
        {
            this.setAge(age);
            this.setName(name);
        }
        public int calcDogYears()
        {
            int dogYears = 15 + (this.age - 1) * 7;
            return dogYears;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            if (age < 0)
                this.age = 0;
            else
                this.age = age;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            bool valid = true;
            char[] n = name.ToCharArray();

            foreach(char c in n){//foreach loop
                if (!char.IsLetter(c)){//if statement
                    valid = false;
                    break;
                }//if statement
            }//foreach loop

            if (valid)
                this.name = name;
            else
                this.name = "";
        }//setName
        public String toString()
        {
            return "Dog [age=" + age + ", name=" + name + "]";
        }
    }
}
