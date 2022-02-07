using NUnit.Framework;
using System.Collections.Generic;


namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            int indexToRemove = 1;
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.AddGroupToRemove();

            app.Groups.Remove(indexToRemove);
            oldGroups.RemoveAt(indexToRemove-1);
            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}