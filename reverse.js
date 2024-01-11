// Create a function to reverse a String
// 'Hi, my name is Joseph' should be:
// hpesoJ si eman ym ,iH

// Solution 1
function reverse1(str) {
  return str.split('').reverse().join('');
}

// Solution 2 - Arrow function
const reverse2 = (str) => str.split('').reverse().join('');

// Solution 3
function reverse3(str) {
  if (!str || str.length < 2 || typeof str !== 'string') {
    return 'Oops! something is wrong.';
  }

  const backward = [];
  const totalItems = str.length - 1;
  for (let i = totalItems; i >= 0; i--) {
    backward.push(str[i]);
  }
  return backward.join('');
}

console.log(reverse3('joseph'));

// console.log(reverse1('Joseph'));
// console.table(reverse2('Testing the reverse function'));
