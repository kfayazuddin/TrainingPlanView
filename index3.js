//Callback hell

console.log('Before');
getUser(1, (user) => {
  getRepositories(user.gitHubUsername, (repos) => {
    getCommits(repos[0], (commits) => {
      console.log(commits);
    })
    console.log('User',user)
  })
});
console.log('After');

function getUser(id, callback) {
  setTimeout(() => {
    console.log('Reading a user from a database...');
    callback({ id: id, gitHubUsername: 'kfayazuddin' });
  }, 2000);
}

function getRepositories(username, callback) {
  setTimeout(() => {
    console.log('Calling GitHub API...');
    callback(['repo1', 'repo2', 'repo3']);
  }, 2000);
}

function getCommits(repo, callback) {
  setTimeout(() => {
    console.log('Calling GitHub APIsss...');
    callback(['commit']);
  }, 2000);
}