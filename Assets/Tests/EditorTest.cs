using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EditorTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void EditorTestSimplePasses()
        {
            // Use the Assert class to test conditions
            var gameObject = new GameObject();
            var newGameObjectName = "My game object";
            gameObject.name = newGameObjectName;
            Assert.AreEqual(newGameObjectName, gameObject.name);
        }
        [Test]
        public void EditorTestSimpleFiled()
        {
            // Use the Assert class to test conditions
            var gameObject = new GameObject();
            var testObjectName = "My game object";
            gameObject.name = "Hello";
            Assert.AreEqual(newGameObjectName, gameObject.name);
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator EditorTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
