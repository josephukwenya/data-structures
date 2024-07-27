// Pagination Logic

const page = parseInt(req.query.page, 10) || 1;
const limit = parseInt(req.query.limit, 10) || 100;
const startIndex = (page - 1) * limit;
const endIndex = page * limit;
const total = await Model.countDocuments(); // Replace Model your model name

query = query.skip(startIndex).limit(limit);

// Pagination result
const pagination = {};

if (endIndex < total) {
  pagination.next = {
    page: page + 1,
    limit,
  };
}

if (startIndex > 0) {
  pagination.prev = {
    page: page - 1,
    limit,
  };
}
