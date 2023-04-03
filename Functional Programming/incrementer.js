// Let's update the incrementer function to clearly declare its dependencies.
// Write the incrementer function so it takes an argument,
// and then returns a result after increasing the value by one.

// The global variable
let fixedValue = 4;

// Only change code below this line
function incrementer(x) {
  x = 1;
  return fixedValue + x;

  // Only change code above this line
}

console.log(fixedValue); // 4 fixedValue
console.log(incrementer()); // 5
