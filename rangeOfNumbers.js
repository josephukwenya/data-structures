// Define a function named rangeOfNumbers with two parameters. The function should return an
// array of integers which begin with a number represented by the startNum parameter and ends with
// a number represented by the endNum parameter. The starting number must also be less than or equal
// to the ending number. You function must use recursion by calling itself and not use loops of any kind.
// It should also work for cases where startNum and endNum are the same.

function rangeOfNumbers(startNum, endNum) {
  if (endNum < startNum) {
    return [];
  } else {
    const num = rangeOfNumbers(startNum, endNum - 1);
    num.push(endNum);
    return num;
  }
}

console.log(rangeOfNumbers(1, 5));
