function sliceArray(anim, beginSlice, endSlice) {
  // Add your code below this line
  return anim.slice(beginSlice, endSlice);
  // Add your code above this line
}
var inputAnim = [
  'Cat',
  'Dog',
  'Tiger',
  'Zebra',
  'Ant'
];
sliceArray(inputAnim, 1, 3);

// The function can be written by simply writing one line of code - a return statement. Just like in the example given, slice the array which the function takes as a parameter using the beginSlice and endSlice parameters as parameters for the slice() method.
// Remember the structure of the slice() method:
