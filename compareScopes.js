// var numArray = [];
// for (var i = 0; i < 3; i++) {
//   numArray.push(i);
// }
// console.log(numArray);
// console.log(i);

function checkScope() {
  var i = "function scope";
  if (true) {
    i = "block scope";
    console.log("Block scope is: ", i);
  }
  console.log("Function scope is: ", i);
  return i;
}

console.log(checkScope());
