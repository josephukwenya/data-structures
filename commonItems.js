// Return true if array1 and array2 have common item and false if otherwise

const array1 = ['j', 'o', 's', 'e', 'p', 'h'];
const array2 = ['u', 'k', 'w', 'e', 'n', 'y', 'a'];

function commonItems(arr1, arr2) {
  for (let i = 0; i < arr1.length; i++) {
    for (let j = 0; j < arr2.length; j++) {
      if (arr1[i] === arr2[j]) {
        return true;
      }
    }
  }
  return false;
}

console.log(commonItems(array1, array2));
