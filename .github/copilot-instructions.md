Always write my python unit tests using pytest, not unittest.
# Rust Web Server Development Guidelines

## General Constraints
- Use only Rust standard library (`std`). No external crates allowed.
- Follow Rust 2021 edition idioms and best practices.
- Implement proper error handling using `Result` and custom error types.

## Architecture Guidelines
- Use `std::net` for TCP networking (specifically `TcpListener` and `TcpStream`)
- Implement HTTP/1.1 protocol parsing manually
- Use `std::io` traits for stream reading/writing
- Follow thread-per-connection model using `std::thread`

## Code Style Requirements
- Use idiomatic Rust naming conventions
- Implement proper documentation using doc comments
- Use strong typing and avoid `unwrap()` in production code
- Handle all potential errors explicitly
- Use constants for configuration values

## Testing Requirements
- Write unit tests for all public functions
- Include integration tests for server components
- Test edge cases in HTTP parsing
- Use `std::io::Cursor` for mocking streams in tests

## Security Requirements
- Validate all input data
- Implement proper request size limits
- Handle malformed requests gracefully
- Implement basic DOS protection through connection timeouts