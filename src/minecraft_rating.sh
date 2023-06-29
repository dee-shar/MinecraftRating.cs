#!/bin/bash

api="https://minecraftrating.ru"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function register()  {
	# 1 - login: (string): <login>
	# 2 - email: (string): <email>
	# 3 - password: (string): <password>
	curl --request POST \
		--url "$api/api/register/" \
		--user-agent "$user_agent" \
		--header "content-type: application/x-www-form-urlencoded" \
		--data "login=$1&email=$2&password=$3"
}

function login()  {
	# 1 - username: (string): <login>
	# 2 - password: (string): <password>
	curl --request POST \
		--url "$api/api/register/" \
		--user-agent "$user_agent" \
		--header "content-type: application/x-www-form-urlencoded" \
		--data "login_name=$1&login_password=$2&login=submit"
}

function add_server() {
	# 1 - server_address: (string): <ip:port>
	curl --request POST \
		--url "$api/api/add-server/" \
		--user-agent "$user_agent" \
		--header "content-type: application/x-www-form-urlencoded" \
		--data "ip=$1"
}
