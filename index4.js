//promises
function getUser(id){
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            console.log('Reading a user from a database...');
            resolve({id: id,getHubUsername:'kfayazuddin'});
        },2000);
    });
}

function getRepositories(username)
{
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            console.log('Calling GitHub API....');
            resolve(['repo1','repo2','repo3']);
        },2000);
    });
}


function getCommits(repo) {
return new Promise((resolve,reject)=>{
    setTimeout(() => {
      console.log('Calling GitHub API...');
      resolve(['commit']);
    }, 2000);
  });
}

getUser(1)
  .then(user => getRepositories(user.getHubUsername))
  .then(repo=>getCommits(repo[0]))
  .then(commits => console.log('commits',commits))
  .catch(err=>console.log('Error',err.message));

