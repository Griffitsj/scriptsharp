// jQuery.cs
// Script#/Libraries/QUnit/QUnit
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace QUnitApi
{
    [IgnoreNamespace]
    [Imported]
    public class QUnit
    {
        /// <summary>
        /// Add a test to run.
        /// </summary>
        /// <param name="name">The name of the test</param>
        /// <param name="test">The actual testing code to run, should include at least one assertion.</param>
        public static void Test(string name, Action test) { }

        /// <summary>
        /// Add a test to run.
        /// </summary>
        /// <param name="name">The name of the test</param>
        /// <param name="expected">How many assertions are expected to run.</param>
        /// <param name="test">The actual testing code to run, should include at least one assertion.</param>
        public static void Test(string name, Number expected, Action test) { }

        /// <summary>
        /// Specify how many assertions are expected to run within a test.
        /// </summary>
        /// <param name="amount">The number of assertions you expect to run.</param>
        public static void Expect(int amount) { }

        /// <summary>
        /// Separate tests into modules.
        /// </summary>
        /// <param name="name">The name of the module</param>
        public static void Module(string name) { }

        /// <summary>
        /// Initialize the test runner (if the runner has already run it'll be re-initialized, effectively resetting it). 
        /// This method does not need to be called in the normal use of QUnit.
        /// </summary>
        public static void Init() { }

        /// <summary>
        /// Automatically called by QUnit after each test. 
        /// Can be called by test code, though usually its better to seperate test code with multiple calls to test().
        /// </summary>
        public static void Reset() { }

        /// <summary>
        /// A boolean assertion, equivalent to JUnit's assertTrue. Passes if the first argument is truthy.
        /// </summary>
        /// <param name="state">A boolean expression, can be a boolean or any other type, its boolean default is evaluated.</param>
        public static void Ok(bool state) { }

        /// <summary>
        /// A boolean assertion, equivalent to JUnit's assertTrue. Passes if the first argument is truthy.
        /// </summary>
        /// <param name="state">A boolean expression, can be a boolean or any other type, its boolean default is evaluated.</param>
        /// <param name="message">A message to output with the assertion result.</param>
        public static void Ok(bool state, string message) { }

        /// <summary>
        /// A comparison assertion, equivalent to JUnit's assertEquals.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        public static void Equal(object actual, object expected) { }

        /// <summary>
        /// A comparison assertion, equivalent to JUnit's assertEquals.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        /// <param name="message">A message to display with the assertion result</param>
        public static void Equal(object actual, object expected, object message) { }

        /// <summary>
        /// A comparison assertion, equivalent to JUnit's assertNotEquals.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        public static void NotEqual(object actual, object expected) { }

        /// <summary>
        /// A comparison assertion, equivalent to JUnit's assertNotEquals.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        /// <param name="message">A message to display with the assertion result</param>
        public static void NotEqual(object actual, object expected, object message) { }

        /// <summary>
        /// A deep recursive comparison assertion, working on primitive types, arrays and objects.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>        
        public static void DeepEqual(object actual, object expected) { }

        /// <summary>
        /// A deep recursive comparison assertion, working on primitive types, arrays and objects.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        /// <param name="message">A message to display with the assertion result</param>
        public static void DeepEqual(object actual, object expected, object message) { }

        /// <summary>
        /// A deep recursive comparison assertion, working on primitive types, arrays and objects, 
        /// with the result inverted, passing when some property isn't equal.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>        
        public static void NotDeepEqual(object actual, object expected) { }

        /// <summary>
        /// A deep recursive comparison assertion, working on primitive types, arrays and objects, 
        /// with the result inverted, passing when some property isn't equal.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        /// <param name="message">A message to display with the assertion result</param>
        public static void NotDeepEqual(object actual, object expected, object message) { }

        /// <summary>
        /// A stricter comparison assertion than equal.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        public static void StrictEqual(object actual, object expected) { }

        /// <summary>
        /// A stricter comparison assertion than equal.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        /// <param name="message">A message to display with the assertion result</param>
        public static void StrictEqual(object actual, object expected, object message) { }

        /// <summary>
        /// A stricter comparison assertion than notEqual.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        public static void NotStrictEqual(object actual, object expected) { }

        /// <summary>
        /// A stricter comparison assertion than notEqual.
        /// </summary>
        /// <param name="actual">The actual result</param>
        /// <param name="expected">The expected result</param>
        /// <param name="message">A message to display with the assertion result</param>
        public static void NotStrictEqual(object actual, object expected, object message) { }

        /// <summary>
        /// Assertion to test if a callback throws an exception when run.
        /// </summary>
        /// <param name="block">Callback to execute, expecting it to throw an exception. Gets called with default scope (window) and no arguments.</param>
        public static void Raises(Action block) { }

        /// <summary>
        /// Assertion to test if a callback throws an exception when run.
        /// </summary>
        /// <param name="block">Callback to execute, expecting it to throw an exception. Gets called with default scope (window) and no arguments.</param>
        /// <param name="expected">An optional verification. Can be a regex to test the thrown exception. Can be a constructor function, tested with instanceof against the exception. Can be a callback - called with the exception as the first argument, return true for a valid exception.</param>
        public static void Raises(Action block, Action expected) { }

        /// <summary>
        /// Assertion to test if a callback throws an exception when run.
        /// </summary>
        /// <param name="block">Callback to execute, expecting it to throw an exception. Gets called with default scope (window) and no arguments.</param>
        /// <param name="expected">An optional verification. Can be a regex to test the thrown exception. Can be a constructor function, tested with instanceof against the exception. Can be a callback - called with the exception as the first argument, return true for a valid exception.</param>
        /// <param name="message">A message to output with the assertion result.</param>
        public static void Raises(Action block, Action expected, string message) { }

        /// <summary>
        /// Assertion to test if a callback throws an exception when run.
        /// </summary>
        /// <param name="block">Callback to execute, expecting it to throw an exception. Gets called with default scope (window) and no arguments.</param>
        /// <param name="message">A message to output with the assertion result.</param>
        public static void Raises(Action block, string message) { }

        /// <summary>
        /// Start running tests again after the testrunner was stopped. See <see cref="Stop()"/>.
        /// </summary>
        public static void Start() { }

        /// <summary>
        /// Start running tests again after the testrunner was stopped. See <see cref="Stop(int)"/>.
        /// <param name="decrement">argument to decrement the semaphore the given times.</param>
        /// </summary>
        public static void Start(int decrement) { }

        /// <summary>
        /// Stop the testrunner to wait for async tests to run. Call <see cref="Start()"/> to continue.
        /// </summary>
        public static void Stop() { }

        /// <summary>
        /// Stop the testrunner to wait for async tests to run. Call <see cref="Start(int)"/> to continue.
        /// <param name="increment">argument to increment the stop-semaphore the given times.</param>
        /// </summary>
        public static void Stop(int increment) { }
    }
}
