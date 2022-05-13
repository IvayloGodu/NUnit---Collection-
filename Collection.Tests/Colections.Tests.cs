using Collections;
using NUnit.Framework;
using System;
using System.Linq;

namespace Collection.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Collection_Empty_Constructor()
        {
            var nums = new Collection<int>();

         
            Assert.That(nums.Count == 0, "Count property");
            Assert.AreEqual(nums.Capacity, 16, "Capacity property");
            Assert.That(nums.ToString() == "[]");
        }
        [Test]
        public void Test_Collection_Initial_Capacity()
        {


            int capacity = 16;

            var nums = new Collection<int>();

           
            Assert.That(nums.Count == 0, "Count property");
            Assert.AreEqual(nums.Capacity, 16, "Capacity property");
            Assert.That(nums.ToString() == "[]");
        }

        [Test]
        public void Test_Collection_Single_Item()
        {
            var nums = new Collection<int>(5);



            Assert.That(nums.ToString, Is.EqualTo("[5]"));

            Assert.That(nums.Count == 1, "Count property");
            Assert.AreEqual(nums.Capacity, 16, "Capacity property");

        }

        [Test]
        public void Test_Collection_Clear()
        {
            var nums = new Collection<int>(5, 10, 15, 25, 35);

            nums.Clear();


            Assert.AreEqual(0, nums.Count);

            Assert.That(nums.Count == 0, "Count property");
            Assert.AreEqual(nums.Capacity, 16, "Capacity property");
            Assert.That(nums.ToString() == "[]");


        }
        [Test]
        public void Test_Collection_Insert_From_the_Start()
        {
            var nums = new Collection<int>(5, 10, 15);

            int index = 0;
            int parameter = 17;

            nums.InsertAt(index, parameter);

            var expected_nums = new Collection<int>(17, 5, 10, 15);

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());

          

        }
        [Test]
        public void Test_Collection_Insert_From_the_End()
        {
            var nums = new Collection<int>(5, 10, 15);

            int index = 3;
            int parameter = 12;

            nums.InsertAt(index, parameter);

            var expected_nums = new Collection<int>(5, 10, 15, 12);

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());

           

        }
        [Test]
        public void Test_Collection_Insert_From_the_Middle()
        {
            var nums = new Collection<int>(5, 10, 15, 19, 24, 32);

            int index = 3;
            int parameter = 24;

            nums.InsertAt(index, parameter);

            var expected_nums = new Collection<int>(5, 10, 15, 24, 19, 24, 32);

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());

         

        }
        [Test]
        public void Test_Collection_Insert_At_Invailid_Positive_Index()
        {
            var nums = new Collection<int>(5, 10, 15, 19, 24, 32);

            Assert.That(() => nums.InsertAt(7, 5),
                Throws.TypeOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void Test_Collection_Insert_At_Invailid_Negative_Index()
        {
            var nums = new Collection<int>(5, 10, 15, 19, 24, 32);

            Assert.That(() => nums.InsertAt(-3, 5),
                Throws.TypeOf<ArgumentOutOfRangeException>());


        }
        [Test]
        public void Test_Collection_Exchange_First_Last()
        {
            var nums = new Collection<int>(5, 10, 15, 35);



            nums.Exchange(0, 3);

            var expected_nums = new Collection<int>(35, 10, 15, 5);

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());
     

        }
        [Test]
        public void Test_Collection_Exchange_First_Middle()
        {
            var nums = new Collection<int>(new int[] { 5, 10, 15, 35 });



            nums.Exchange(1, 2);

            var expected_nums = new Collection<int>(new int[] { 5, 15, 10, 35 });

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());

   

        }
        [Test]
        public void Test_Collection_Exchange_Invailid_Index()
        {
            var nums = new Collection<int>(new int[] { 5, 10, 15, 35 });

            Assert.That(() => nums.Exchange(0, -3),
                Throws.InstanceOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void Test_Collection_Remove_From_the_Start()
        {
            var nums = new Collection<int>(5, 10, 15 );

            nums.RemoveAt(0);

            var expected_nums = new Collection<int>(10, 15 );

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());

        }
        [Test]
        public void Test_Collection_Remove_From_the_End()
        {
            var nums = new Collection<int>(5, 10, 15 );

            nums.RemoveAt(2);

            var expected_nums = new Collection<int>(5, 10);

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());

        }
        [Test]
        public void Test_Collection_Remove_From_the_Middle()
        {
            var nums = new Collection<int>(5, 10, 15 );

            nums.RemoveAt(1);

            var expected_nums = new Collection<int>(5, 15 );

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());

        }
        [Test]
        public void Test_Collection_Remove_Number_From_Inavalid_Negative_Index()
        {
            var nums = new Collection<int>(5, 10, 15 );

            Assert.That(() => nums.RemoveAt(-2),
                Throws.InstanceOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void Test_Collection_Remove_Number_From_Inavalid_Positive_Index()
        {
            var nums = new Collection<int>(5, 10, 15);

            Assert.That(() => nums.RemoveAt(5),
                Throws.InstanceOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void Test_Collection_Add()
        {
            var nums = new Collection<int>(5, 10, 15 );

            nums.Add(2);

            var expected_nums = new Collection<int>( 5, 10, 15, 2);

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());

        }
        [Test]
        public void Test_Collection_Count()
        {
            var nums = new Collection<int>(5, 10, 15, 7, 68, 56, 74 );

            var counts = 7;

            Assert.AreEqual(counts, nums.Count);

        }
        [Test]
        public void Test_Collection_This()
        {
            var nums = new Collection<int>(5, 10, 15, 7, 68, 56, 74 );

            var This = nums[2];

            Assert.AreEqual(This, nums[2]);

        }
        [Test]
        public void Test_Collection_Add_Range()
        {
            var nums = new Collection<int>(5, 10, 15);

            var new_range = new int[] { 48, 56, 74 };
            nums.AddRange(new_range);

            var expected_nums = new Collection<int>(5, 10, 15, 48, 56, 74);

            Assert.AreEqual(expected_nums.ToString(), nums.ToString());
           
        }
        [Test]
        public void Test_Collection_AddRange_With_Grow()
        {
            var nums = new Collection<int>();
            int oldCapacity = nums.Capacity;

            var newNums = Enumerable.Range(1000, 2000).ToArray();

            nums.AddRange(newNums);

            string expectedNums = "[" + string.Join(", ", newNums) + "]";

            Assert.AreEqual(expectedNums, nums.ToString());
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(oldCapacity));
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(nums.Count));



        }

        [Test]
        public void Test_Collection_Get_By_Index()
        {
            var nums = new Collection<int>( 5, 10, 15, 7, 68, 56, 74 );

            

            Assert.AreEqual(nums[0], 5);
            Assert.AreEqual(nums[6], 74);

        }
        [Test]
        public void Test_Collection_Get_By_Invailid_Idex()
        {
            var nums = new Collection<int>(new int[] { 5, 10, 15, 7, 68, 56, 74 });
            var last_num_index = 9;
            Assert.That(() => nums[last_num_index],
                Throws.InstanceOf<ArgumentOutOfRangeException>());

        }
        
        [Test]
        public void Test_Collection_Set_With_Index()
        {
            var collection = new Collection<int>(1, 2, 3);
            collection[2] = 4;
            Assert.AreEqual(4, collection[2]);
        }
        [Test]
        public void Test_Collection_Set_By_Invailid_Index()
        {
            var nums = new Collection<int>(5, 10, 15, 7, 68, 56, 74 );

            Assert.That(() => nums[-6],
                Throws.InstanceOf<ArgumentOutOfRangeException>());

          
        }
        
        [Test]
        [Timeout(5000)]
        public void Test_Collection_1MillionItems()
        {
            const int itemsCount = 10000;
            var nums = new Collection<int>();

            nums.AddRange(Enumerable.Range(1, itemsCount).ToArray());
            Assert.That(nums.Count == itemsCount);
            Assert.That(nums.Capacity >= nums.Count);
            for (int i = itemsCount - 1; i >= 0; i--)
                nums.RemoveAt(i);
            Assert.That(nums.ToString() == "[]");
            Assert.That(nums.Capacity >= nums.Count);
        }

        [TestCase("Peter", 0, "Peter")]
        [TestCase("Peter, Maria, George", 0, "Peter")]
        [TestCase("Peter, Maria, George", 1, "Maria")]
        [TestCase("Peter, Maria, George", 2, "George")]
        public void alabala(
            string data, int index, string expectedValue)
        {
            // Arrange
            var nums = new Collection<string>(data.Split(", "));

            // Act

            var actual = nums[index];

            // Assert
            Assert.AreEqual(expectedValue, actual);
        }
        
        
    }
}