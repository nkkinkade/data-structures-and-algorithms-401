using System;
using System.Collections.Generic;
using System.Text;
using Challenges.LinkedLists;
using DataStructures.LinkedLists;
using Xunit;

namespace Challenges.test.LinkedListsTest
{
    public class LinkedListTest
    {
        [Fact]
        public void Zipper_returns_1_list_of_2_lists_alternating_values()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(1);
            list1.Insert(3);
            list1.Insert(5);

            list2.Insert(2);
            list2.Insert(4);
            list2.Insert(6);

            LinkedList expected = new LinkedList();
            expected.Insert(1);
            expected.Insert(2);
            expected.Insert(3);
            expected.Insert(4);
            expected.Insert(5);
            expected.Insert(6);

            // Act
            LinkedList result = LLChallenges.Zipper(list1, list2);

            // Assert
            Assert.Equal(expected.ToString(), result.ToString());
        }

        [Fact]
        public void Zipper_returns_properly_if_lists_are_different_lengths()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(3);

            list2.Insert(1);
            list2.Insert(2);
            list2.Insert(4);

            LinkedList expected = new LinkedList();
            expected.Insert(1);
            expected.Insert(2);
            expected.Insert(3);
            expected.Insert(4);

            // Act
            LinkedList result = LLChallenges.Zipper(list1, list2);

            // Assert
            Assert.Equal(expected.ToString(), result.ToString());
        }

        [Fact]
        public void Zipper_zipps_with_empty_list()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list2.Insert(1);
            list2.Insert(2);
            list2.Insert(3);

            LinkedList expected = new LinkedList();
            expected.Insert(1);
            expected.Insert(2);
            expected.Insert(3);

            // Act
            LinkedList result = LLChallenges.Zipper(list1, list2);

            // Assert
            Assert.Equal(expected.ToString(), result.ToString());
        }
    }
}
