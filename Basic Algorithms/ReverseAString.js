// 1) SOLUTION

const reverseString = (str) => {
  return [...str.toString()].reverse().join("");
}

reverseString("hello");
console.log(reverseString("hello"));


// 2) SOLUTION

// function reverveString(str){
// 	return str.toLowerCase().split("").reverse().join("");
// }

// console.log(reverveString('Hello'));


// 3) SOLUTION

// function reverseString(str) {
//   let reverseStr = '';

//   for(let i = str.length - 1; i>=0; i--){
//     reverseStr += str[i];
//   }
//   return reverseStr;
// }

// reverseString("hello");
// console.log(reverseString("hello"));