
generate: openapi-generator.jar
	java -jar openapi-generator.jar generate -i http://localhost:8001/openapi.json -g csharp -o client

openapi-generator.jar:
	curl -sSfL 'https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/7.9.0/openapi-generator-cli-7.9.0.jar' > openapi-generator.jar
