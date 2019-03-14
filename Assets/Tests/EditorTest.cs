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
        [Category("PassedTests")]
        public void EditorTestSimplePasses()
        {
            // Use the Assert class to test conditions
            var gameObject = new GameObject();
            var newGameObjectName = "My game object";
            gameObject.name = newGameObjectName;
            Assert.AreEqual(newGameObjectName, gameObject.name);
        }
        [Test]
        [Category("FailedTests")]
        public void EditorTestSimpleFiled()
        {
            // Use the Assert class to test conditions
            var gameObject = new GameObject();
            var testObjectName = "My game object";
            gameObject.name = "Hello";
            Assert.AreEqual(testObjectName, gameObject.name);
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        [Category("PassedTests")]
        public IEnumerator EditorTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
