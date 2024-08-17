console.log('before')
const user = getUser(1)
console.log(user)
console.log('after')

function getUser(id)
{
    setTimeout(()=>{
    console.log('reading the user details from database');
    return {id:id,gitHubUserName :'kfayazuddin'};
},2000);
}