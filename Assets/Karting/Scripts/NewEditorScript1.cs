using UnityEngine;
using UnityEditor;

namespace Assets.Karting.Scripts
{
    public class NewEditorScript1 : ScriptableObject
    {
        [Test]
        public void BasicTest()
        {

            bool isActive = false;

            Assert.AreEqual(false, isActive);

        }
    }
}