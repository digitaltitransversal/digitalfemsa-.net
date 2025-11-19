test:
	dotnet test --no-build -p:CollectCoverage=true -p:CoverletOutputFormat=lcov -p:CoverletOutput=coverage/

publish:
	make clean && dotnet pack -c Release

clean:
	dotnet clean
csharp:
	rm -rf /docs && \
	rm -rf src/DigitalFemsa.net/Model && \
	docker run --rm \
	-v ${PWD}:/local openapitools/openapi-generator-cli:v7.5.0 generate \
    -i https://raw.githubusercontent.com/digitalfemsa/openapi/main/_build/api.yaml \
    -g csharp \
    -o /local \
    -c /local/config-netcore.json \
    --global-property modelTests=true

update-version:
	@if [ -z "$(VERSION)" ]; then \
		echo "Usage: make update-version VERSION=1.0.1"; \
		exit 1; \
	fi
	@echo "Updating version to $(VERSION)..."
	@echo "$(VERSION)" > VERSION
	@sed -i '' -E 's#<Version>[^<]*</Version>#<Version>$(VERSION)</Version>#' src/DigitalFemsa.net/DigitalFemsa.net.csproj
	@sed -i '' -E 's/public const string Version = "[^"]*"/public const string Version = "$(VERSION)"/' src/DigitalFemsa.net/Client/Configuration.cs
	@sed -i '' -E 's/(SDK Package Version: )[0-9.]+/\1$(VERSION)/' src/DigitalFemsa.net/Client/Configuration.cs
	@# Opcional: si el README fija una versión explícita en el comando de instalación, actualízala
	@sed -i '' -E 's/(Install-Package DigitalFemsa\.net -Version )[0-9.]+/\1$(VERSION)/' README.md || true
	@echo "✨ Version updated to $(VERSION) successfully!"
