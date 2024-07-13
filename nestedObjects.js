// Access the myStorage object and assign the contents to the glove box property
// to the gloveBoxContents variable. Use the dot notation for all property
// where possible, otherwise use bracket notation.

const myStorage = {
  car: {
    inside: {
      "glove box": "maps",
      "passenger seats": "crumbs",
    },
    outside: {
      trunk: "jack",
    },
  },
};

// const gloveBoxContents = "new value";
// myStorage.car.inside["glove box"] = gloveBoxContents;

const gloveBoxContents = myStorage.car.inside["glove box"];

console.log(gloveBoxContents);
// console.log(myStorage);
