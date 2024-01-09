// Palindrome checker to either return true or false
const palindromechecker = (str) => {
  const p = str.toLowerCase().match(/[a-z0-9]/g);
  return p.join('') === p.reverse().join('');
};

console.log(palindromechecker('eye'));
