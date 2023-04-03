function titleCase(str) {
  return str
    .toLowerCase()
    .split(' ')
    .map(val =>
      val.replace(
        val.charAt(0),
        val.charAt(0).toUpperCase()
      )
    )
    .join(' ');
}

console.log(titleCase("I'm a little tea pot"));

// function titleCase(str) {
//   const newTitle = str.split(" ");
//   const updatedTitle = [];
//   for (let st in newTitle) {
//     updatedTitle[st] = newTitle[st][0].toUpperCase() + newTitle[st].slice(1).toLowerCase();
//   }
//   return updatedTitle.join(" ");
// }

// function titleCase(str) {
//   return str
//     .toLowerCase()
//     .replace(/(^|\s)\S/g, L => L.toUpperCase());
// }

// Code Explanation
// The solution works by first lowercasing all the characters in the string and then only uppercasing the first character of each word.

// Lowercase the whole string using str.toLowerCase().
// Replace every word’ first character to uppercase using .replace.
// Search for character at the beginning of each word i.e. matching any character following a space or matching the first character of the whole string, by using the following pattern.
// Regex explanation:
// Find all non-whitespace characters (\S)
// At the beginning of string (^)
// Or after any whitespace character (\s)
// The g modifier searches for other such word pattern in the whole string and replaces them.

// This solution works with national symbols and accented letters as illustrated by following examples
// international characters: ‘бабушка курит трубку’ // → ‘Бабушка Курит Трубку’
// accented characters: ‘località àtilacol’ // → ‘Località Àtilacol’
